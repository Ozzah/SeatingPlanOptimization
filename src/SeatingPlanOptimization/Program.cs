using System.Text;
using CommandLine;
using Ozzah.SeatingPlanOptimization.Model;

namespace Ozzah.SeatingPlanOptimization;

public static class Program
{
	public static void Main(string[] args)
	{
		var parserResult = Parser
			.Default
			.ParseArguments<CommandLineOptions>(args);

		parserResult.WithParsed(SolveSeatingProblem);
	}

	static void SolveSeatingProblem(CommandLineOptions options)
	{
		var tables = ReadTablesFile(options.TablesFilePath!);
		var guests = ReadGuestList(options.GuestsFilePath!);
		var pairingCoefficients = ReadPairingCoefficients(options.GuestsFilePath!, guests);

		var solverParams = GetSolverParams(options);

		var phase1Problem = SetUpProblemPhase1(tables, guests, pairingCoefficients, options);
		SolveSeatingProblem(phase1Problem, solverParams);
		if (!string.IsNullOrEmpty(options.Phase1ResultsFilePath))
		{
			WriteSeatingPlan(
				tables,
				guests,
				phase1Problem,
				pairingCoefficients,
				options.Phase1ResultsFilePath);
		}

		var phase2Problem = SetUpProblemPhase2(tables, guests, pairingCoefficients, phase1Problem, options);
		SolveSeatingProblem(phase2Problem, solverParams);
		WriteSeatingPlan(
			tables,
			guests,
			phase2Problem,
			pairingCoefficients,
			options.Phase2ResultsFilePath!);
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

	static IDictionary<(Guest, Guest), double> ReadPairingCoefficients(
		string guestsFilePath,
		IList<Guest> guests)
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
		var problem = new SeatingProblem(options.SolverType);

		CreateTableUsageVariables(tables, problem);
		CreateGuestToTableVariables(tables, guests, problem);
		CreateTableCapacityConstraints(tables, guests, problem);
		CreateGuestAssignmentConstraints(tables, guests, problem);
		CreateLinearizationScheme(tables, guests, problem);

		if (options.BreakSymmetry)
		{
			CreateSymmetryBreakingConstraints(tables, guests, pairingCoefficients, problem);
		}

		CreateObjectiveFunctionPhase1(tables, guests, pairingCoefficients, problem);

		ConfigureSolver(options, problem);

		return problem;
	}

	static SeatingProblem SetUpProblemPhase2(
		IList<Table> tables,
		IList<Guest> guests,
		IDictionary<(Guest, Guest), double> pairingCoefficients,
		SeatingProblem phase1Problem,
		CommandLineOptions options)
	{
		var problem = new SeatingProblem(options.SolverType);

		CreateTableUsageVariables(tables, problem);
		CreateGuestToTableVariables(tables, guests, problem);
		CreateTableCapacityConstraints(tables, guests, problem);
		CreateGuestAssignmentConstraints(tables, guests, problem);
		CreateLinearizationScheme(tables, guests, problem);

		if (options.BreakSymmetry)
		{
			CreateSymmetryBreakingConstraints(tables, guests, pairingCoefficients, problem);
		}

		RestrictPhase2WithRespectToPhase1Objective(
			tables,
			guests,
			pairingCoefficients,
			phase1Problem.Solver.Objective().Value(),
			options,
			problem);

		CreateObjectiveFunctionPhase2(tables, guests, pairingCoefficients, problem);
		SetPhase2Hint(tables, guests, phase1Problem, problem);

		ConfigureSolver(options, problem);

		return problem;
	}

	static void CreateGuestToTableVariables(
		IList<Table> tables,
		IList<Guest> guests,
		SeatingProblem problem)
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

	static void CreateTableUsageVariables(IList<Table> tables, SeatingProblem problem)
	{
		problem.TableUsed = new Variable[tables.Count];
		for (var k = 0; k < tables.Count; k++)
		{
			problem.TableUsed[k] = problem.Solver.MakeBoolVar($"T_{k}");
		}
	}

	static void CreateTableCapacityConstraints(
		IList<Table> tables,
		IList<Guest> guests,
		SeatingProblem problem)
	{
		for (var k = 0; k < tables.Count; k++)
		{
			var minConstraint = problem.MakeConstraint(0.0, double.PositiveInfinity, $"__TableMin_{k}");
			minConstraint.SetCoefficient(problem.TableUsed![k], -tables[k].MinimumGuests);

			for (var j = 0; j < guests.Count; j++)
			{
				minConstraint.SetCoefficient(problem.GuestToTable![j, k], 1.0);
			}

			var maxConstraint = problem.MakeConstraint(double.NegativeInfinity, 0.0, $"__TableMax_{k}");
			maxConstraint.SetCoefficient(problem.TableUsed![k], -tables[k].MaximumGuests);

			for (var j = 0; j < guests.Count; j++)
			{
				maxConstraint.SetCoefficient(problem.GuestToTable![j, k], 1.0);
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
			var constraint = problem.MakeConstraint(
				1.0,
				1.0,
				$"__Guest_{j}");

			for (var k = 0; k < tables.Count; k++)
			{
				constraint.SetCoefficient(problem.GuestToTable![j, k], 1.0);
			}
		}
	}

	static void CreateLinearizationScheme(
		IList<Table> tables,
		IList<Guest> guests,
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

					var linearizationConstraint1 = problem.MakeConstraint(
						double.NegativeInfinity,
						0.0,
						$"__Linearize1_{i}_{j}_{k}");
					linearizationConstraint1.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
					linearizationConstraint1.SetCoefficient(problem.GuestToTable![i, k], -1.0);

					var linearizationConstraint2 = problem.MakeConstraint(
						double.NegativeInfinity,
						0.0,
						$"__Linearize2_{i}_{j}_{k}");
					linearizationConstraint2.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
					linearizationConstraint2.SetCoefficient(problem.GuestToTable[j, k], -1.0);

					var linearizationConstraint3 = problem.MakeConstraint(
						-1.0,
						double.PositiveInfinity,
						$"__Linearize3_{i}_{j}_{k}");
					linearizationConstraint3.SetCoefficient(problem.GuestWithGuestToTable[i, j, k], 1.0);
					linearizationConstraint3.SetCoefficient(problem.GuestToTable[i, k], -1.0);
					linearizationConstraint3.SetCoefficient(problem.GuestToTable[j, k], -1.0);
				}
			}
		}
	}

	static void CreateSymmetryBreakingConstraints(
		IList<Table> tables,
		IList<Guest> guests,
		IDictionary<(Guest, Guest), double> pairingCoefficients,
		SeatingProblem problem)
	{
		for (var k1 = 0; k1 < tables.Count; k1++)
		{
			for (var k2 = k1 + 1; k2 < tables.Count; k2++)
			{
				if (tables[k1].MinimumGuests != tables[k2].MinimumGuests ||
					tables[k1].MaximumGuests != tables[k2].MaximumGuests)
				{
					continue;
				}

				var constraint1 = problem.Solver.MakeConstraint(0.0, double.PositiveInfinity, $"__Symm1_{k1}_{k2}");
				constraint1.SetCoefficient(problem.TableUsed![k1], 1.0);
				constraint1.SetCoefficient(problem.TableUsed![k2], -1.0);

				var constraint2 = problem.Solver.MakeConstraint(0.0, double.PositiveInfinity, $"__Symm2_{k1}_{k2}");
				for (var i = 0; i < guests.Count; i++)
				{
					for (var j = i + 1; j < guests.Count; j++)
					{
						constraint2.SetCoefficient(
							problem.GuestWithGuestToTable![i, j, k1],
							pairingCoefficients[(guests[i], guests[j])]);

						constraint2.SetCoefficient(
							problem.GuestWithGuestToTable![i, j, k2],
							-pairingCoefficients[(guests[i], guests[j])]);
					}
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

	static void RestrictPhase2WithRespectToPhase1Objective(
		IList<Table> tables,
		IList<Guest> guests,
		IDictionary<(Guest, Guest), double> pairingCoefficients,
		double objectiveValuePhase1,
		CommandLineOptions options,
		SeatingProblem problem)
	{
		var constraint = problem.MakeConstraint(
			options.Phase2Tolerances * objectiveValuePhase1,
			objectiveValuePhase1 + options.MipGap,
			"__Z1");
		for (var i = 0; i < guests.Count; i++)
		{
			for (var j = i + 1; j < guests.Count; j++)
			{
				for (var k = 0; k < tables.Count; k++)
				{
					constraint.SetCoefficient(
						problem.GuestWithGuestToTable![i, j, k],
						pairingCoefficients[(guests[i], guests[j])]);
				}
			}
		}
	}

	static void CreateObjectiveFunctionPhase2(
		IList<Table> tables,
		IList<Guest> guests,
		IDictionary<(Guest, Guest), double> pairingCoefficients,
		SeatingProblem problem)
	{
		problem.PoorestGuestReward = problem.Solver.MakeNumVar(double.NegativeInfinity, double.PositiveInfinity, "Z2");

		problem.GuestReward = new Variable[guests.Count];
		for (var i = 0; i < guests.Count; i++)
		{
			problem.GuestReward[i] = problem.Solver.MakeNumVar(double.NegativeInfinity, double.PositiveInfinity, $"Z2_{i}");

			var guestConstraint = problem.MakeConstraint(0.0, 0.0, $"__Z2_{i}");
			guestConstraint.SetCoefficient(problem.GuestReward[i], 1.0);
			for (var j = 0; j < guests.Count; j++)
			{
				if (i == j)
				{
					continue;
				}

				for (var k = 0; k < tables.Count; k++)
				{
					var iMin = Math.Min(i, j);
					var jMax = Math.Max(i, j);

					guestConstraint.SetCoefficient(
						problem.GuestWithGuestToTable![iMin, jMax, k],
						-pairingCoefficients[(guests[iMin], guests[jMax])]);
				}
			}

			var totalConstraint = problem.MakeConstraint(double.NegativeInfinity, 0.0, $"__Z_Z2_{i}");
			totalConstraint.SetCoefficient(problem.PoorestGuestReward, 1.0);
			totalConstraint.SetCoefficient(problem.GuestReward[i], -1.0);
		}

		problem.Solver.Objective().SetCoefficient(problem.PoorestGuestReward, 1.0);
		problem.Solver.Objective().SetOptimizationDirection(maximize: true);
	}

	static void SetPhase2Hint(
		IList<Table> tables,
		IList<Guest> guests,
		SeatingProblem phase1Problem,
		SeatingProblem problem)
	{
		var hint = new Dictionary<Variable, double>();

		for (var k = 0; k < tables.Count; k++)
		{
			hint.Add(
				problem.TableUsed![k],
				phase1Problem.TableUsed![k].SolutionValue() > 0.5 ? 1.0 : 0.0);
		}

		for (var j = 0; j < guests.Count; j++)
		{
			for (var k = 0; k < tables.Count; k++)
			{
				hint.Add(
					problem.GuestToTable![j, k],
					phase1Problem.GuestToTable![j, k].SolutionValue() > 0.5 ? 1.0 : 0.0);
			}
		}

		for (var i = 0; i < guests.Count; i++)
		{
			for (var j = i + 1; j < guests.Count; j++)
			{
				for (var k = 0; k < tables.Count; k++)
				{
					hint.Add(
						problem.GuestWithGuestToTable![i, j, k],
						phase1Problem.GuestWithGuestToTable![i, j, k].SolutionValue() > 0.5 ? 1.0 : 0.0);
				}
			}
		}

		problem.Solver.SetHint(
			hint.Keys.ToArray(),
			hint.Values.ToArray());
	}

	static MPSolverParameters GetSolverParams(CommandLineOptions options)
	{
		var solverParams = new MPSolverParameters();
		solverParams.SetDoubleParam(MPSolverParameters.DoubleParam.RELATIVE_MIP_GAP, options.MipGap);
		return solverParams;
	}

	static void ConfigureSolver(CommandLineOptions options, SeatingProblem problem)
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

	static SeatingProblem SolveSeatingProblem(
		SeatingProblem seatingProblem,
		MPSolverParameters solverParams)
	{
		ConsoleCancelEventHandler cancelHandler = (_, _) => seatingProblem.Solver.InterruptSolve();
		var solveTask = Task.Run(() => seatingProblem.Solver.Solve(solverParams));
		Console.CancelKeyPress += cancelHandler;
		Task.WaitAll(solveTask);
		Console.CancelKeyPress -= cancelHandler;
		return seatingProblem;
	}

	static void WriteSeatingPlan(
		IList<Table> tables,
		IList<Guest> guests,
		SeatingProblem problem,
		IDictionary<(Guest, Guest), double> pairingCoefficients,
		string resultsPath)
	{
		var solutionValue = 0.0;

		using var writer = new StreamWriter(resultsPath);
		for (var k = 0; k < tables.Count; k++)
		{
			if (problem.TableUsed![k].SolutionValue() < 0.5)
			{
				writer.WriteLine($"TABLE {k + 1} (UNUSED)");
				writer.WriteLine();
				continue;
			}

			var tableValue = 0.0;

			var tableBuilder = new StringBuilder();
			for (var j = 0; j < guests.Count; j++)
			{
				if (problem.GuestToTable![j, k].SolutionValue() > 0.5)
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

					tableBuilder.Append($"\t{guests[j].Name} ({guestValue})\n");
					tableValue += guestValue;
				}
			}

			writer.WriteLine($"TABLE {k + 1} ({tableValue})");
			writer.Write(tableBuilder.ToString());
			solutionValue += tableValue;

			writer.WriteLine(string.Empty);
		}

		writer.WriteLine($"Solution Value: {solutionValue}");
	}
}
