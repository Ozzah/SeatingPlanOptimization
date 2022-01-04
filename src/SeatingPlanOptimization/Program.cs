using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;
using Google.OrTools.LinearSolver;
using Ozzah.SeatingPlanOptimization.Model;

namespace Ozzah.SeatingPlanOptimization
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var parserResult = Parser
				.Default
				.ParseArguments<CommandLineOptions>(args);

			parserResult.WithParsed(options => SolveProblem(options));
		}

		static void SolveProblem(CommandLineOptions options)
		{
			var tables = ReadTablesFile(options.TablesFilePath!);
			var guests = ReadGuestList(options.GuestsFilePath!);
			var pairingCoefficients = ReadPairingCoefficients(options.GuestsFilePath!, guests);
			
			var phase1Problem = SetUpProblemPhase1(tables, guests, pairingCoefficients, options);
			if (!string.IsNullOrWhiteSpace(options.ModelFilePath))
			{
				File.WriteAllText(
					options.ModelFilePath,
					phase1Problem.Solver.ExportModelAsLpFormat(false));
			}
			phase1Problem.Solver.Solve();
			WriteSolution(tables, guests, phase1Problem, pairingCoefficients, options);
		}

		static IList<Table> ReadTablesFile(string tablesFilePath)
		{
			if (!File.Exists(tablesFilePath))
			{
				throw new InvalidOperationException($"Table file '{tablesFilePath}' does not exist");
			}
			
			return File.ReadLines(tablesFilePath)
				.Skip(1)
				.Select(line => line.Split('\t'))
				.Select((line, idx) => new Table(
					idx,
					Convert.ToInt32(line[0]),
					Convert.ToInt32(line[1])))
				.ToList();
		}

		static IList<Guest> ReadGuestList(string guestsFilePath)
		{
			if (!File.Exists(guestsFilePath))
			{
				throw new InvalidOperationException($"Guest file '{guestsFilePath}' does not exist");
			}

			return File.ReadLines(guestsFilePath)
				.Skip(1)
				.Select(line => line.Split('\t'))
				.Select((line, idx) => new Guest(
					idx,
					line[0]))
				.ToList();
		}

		static IDictionary<(Guest, Guest), double> ReadPairingCoefficients(string guestsFilePath, IList<Guest> guests)
		{
			if (!File.Exists(guestsFilePath))
			{
				throw new InvalidOperationException($"Guest file '{guestsFilePath}' does not exist");
			}

			var pairingCoefficients = new Dictionary<(Guest, Guest), double>();
			File.ReadLines(guestsFilePath)
				.Skip(1)
				.Take(guests.Count - 1)
				.Select(line => line.Split('\t'))
				.Select((line, idx) => (line, idx))
				.ToList()
				.ForEach(tup =>
				{
					var idx = tup.idx;
					var line = tup.line;
					
					for (var jdx = idx + 1; jdx < guests.Count; jdx++)
					{
						pairingCoefficients.Add(
							(guests[idx], guests[jdx]),
							Convert.ToDouble(line[jdx + 1]));
					}
				});

			return pairingCoefficients;
		}

		static SeatingProblem SetUpProblemPhase1(
			IList<Table> tables,
			IList<Guest> guests,
			IDictionary<(Guest, Guest), double> pairingCoefficients,
			CommandLineOptions options)
		{
			var problem = new SeatingProblem();

			CreateGuestToTableVariables(tables, guests, problem);
			CreateTableCapacityConstraints(tables, guests, problem);
			CreateGuestAssignmentConstraints(tables, guests, problem);
			CreateLinearizationScheme(tables, guests, pairingCoefficients, problem);
			
			CreateObjectiveFunctionPhase1(tables, guests, pairingCoefficients, problem);
			
			SetUpSolverParameters(options, problem);

			return problem;
		}
		
		static void CreateGuestToTableVariables(IList<Table> tables, IList<Guest> guests, SeatingProblem problem)
		{
			problem.GuestToTable = new Variable[guests.Count, tables.Count];
			for (var j = 0; j < guests.Count; j++)
			{
				for (var k = 0; k < tables.Count; k++)
				{
					problem.GuestToTable[j, k] = problem.Solver.MakeBoolVar($"X_{j}_{k}");
				}
			}
		}

		static void CreateTableCapacityConstraints(IList<Table> tables, IList<Guest> guests, SeatingProblem problem)
		{
			for (var k = 0; k < tables.Count; k++)
			{
				var constraint = problem.Solver.MakeConstraint(
					tables[k].MinimumGuests,
					tables[k].MaximumGuests,
					$"__Table_{k}");
				problem.Constraints.Add(constraint);

				for (var j = 0; j < guests.Count; j++)
				{
					constraint.SetCoefficient(problem.GuestToTable![j, k], 1.0);
				}
			}
		}

		static void CreateGuestAssignmentConstraints(
			IList<Table> tables,
			IList<Guest> guests,
			SeatingProblem problem)
		{
			for (var j = 0; j < guests.Count; j++)
			{
				var constraint = problem.Solver.MakeConstraint(
					1.0,
					1.0,
					$"__Guest_{j}");
				problem.Constraints.Add(constraint);

				for (var k = 0; k < tables.Count; k++)
				{
					constraint.SetCoefficient(problem.GuestToTable![j, k], 1.0);
				}
			}
		}
		
		static void CreateLinearizationScheme(
			IList<Table> tables,
			IList<Guest> guests,
			IDictionary<(Guest, Guest), double> pairingCoefficients,
			SeatingProblem problem)
		{
			problem.GuestWithGuestToTable = new Variable[guests.Count, guests.Count, tables.Count];
			for (var i = 0; i < guests.Count; i++)
			{
				for (var j = i + 1; j < guests.Count; j++)
				{
					for (var k = 0; k < tables.Count; k++)
					{
						problem.GuestWithGuestToTable[i, j, k] = problem.Solver.MakeBoolVar($"Assignment__{i}_{j}_{k}");

						var linearizationConstraint1 = problem.Solver.MakeConstraint(
							double.NegativeInfinity,
							0.0,
							$"__Linearize1_{i}_{j}_{k}");
						linearizationConstraint1.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
						linearizationConstraint1.SetCoefficient(problem.GuestToTable![i, k], -1.0);
						problem.Constraints.Add(linearizationConstraint1);

						var linearizationConstraint2 = problem.Solver.MakeConstraint(
							double.NegativeInfinity,
							0.0,
							$"__Linearize2_{i}_{j}_{k}");
						linearizationConstraint2.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
						linearizationConstraint2.SetCoefficient(problem.GuestToTable[j, k], -1.0);
						problem.Constraints.Add(linearizationConstraint2);

						var linearizationConstraint3 = problem.Solver.MakeConstraint(
							-1.0,
							double.PositiveInfinity,
							$"__Linearize3_{i}_{j}_{k}");
						linearizationConstraint3.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
						linearizationConstraint3.SetCoefficient(problem.GuestToTable[i, k], -1.0);
						linearizationConstraint3.SetCoefficient(problem.GuestToTable[j, k], -1.0);
						problem.Constraints.Add(linearizationConstraint3);
					}
				}
			}
		}

		static void CreateObjectiveFunctionPhase1(
			IList<Table> tables,
			IList<Guest> guests,
			IDictionary<(Guest, Guest), double> pairingCoefficients,
			SeatingProblem problem)
		{
			for (var i = 0; i < guests.Count; i++)
			{
				for (var j = i + 1; j < guests.Count; j++)
				{
					for (var k = 0; k < tables.Count; k++)
					{
						problem.Solver.Objective().SetCoefficient(
							problem.GuestWithGuestToTable![i, j, k],
							pairingCoefficients[(guests[i], guests[j])]);
					}
				}
			}
			
			problem.Solver.Objective().SetOptimizationDirection(maximize: true);
		}

		static void SetUpSolverParameters(CommandLineOptions options, SeatingProblem problem)
		{
			problem.Solver.EnableOutput();
			if (options.NumThreads > 0)
			{
				problem.Solver.SetNumThreads(options.NumThreads);
			}
			if (options.TimeLimitMinutes > 0)
			{
				problem.Solver.SetTimeLimit(options.TimeLimitMinutes * 60000L);
			}
		}
		
		static void WriteSolution(
			IList<Table> tables,
			IList<Guest> guests,
			SeatingProblem problem,
			IDictionary<(Guest, Guest), double> pairingCoefficients,
			CommandLineOptions options)
		{
			var solutionValue = 0.0;
			
			using var writer = new StreamWriter(options.ResultsFilePath!);
			for (var k = 0; k < tables.Count; k++)
			{
				var tableValue = 0.0;
				
				writer.WriteLine($"TABLE {k + 1}:");
				for (var j = 0; j < guests.Count; j++)
				{
					if (problem.GuestToTable![j, k].SolutionValue() > 0.9)
					{
						var guestValue = 0.0;
						
						for (var i = 0; i < guests.Count; i++)
						{
							if (i != j)
							{
								var iMin = Math.Min(i, j);
								var jMax = Math.Max(i, j);

								guestValue += 
									pairingCoefficients[(guests[iMin], guests[jMax])] *
									problem.GuestWithGuestToTable![iMin, jMax, k].SolutionValue();
							}
						}
						
						writer.WriteLine($"\t{guests[j].Name} ({guestValue})");
						tableValue += guestValue;
					}
				}
				
				writer.WriteLine($"Table Value: {tableValue}");
				solutionValue += tableValue;
				
				writer.WriteLine(string.Empty);
			}
			
			writer.WriteLine($"Solution Value: {solutionValue}");
		}
	}
}
