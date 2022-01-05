using CommandLine;
using Ozzah.SeatingPlanOptimization.Model;

namespace Ozzah.SeatingPlanOptimization
{
	public class CommandLineOptions
	{
		[Option(
			longName: "TablesFile",
			shortName: 't',
			Required = true,
			HelpText = "Path the the file containing table information")]
		public string? TablesFilePath { get; set; }
		
		[Option(
			longName: "GuestsFile",
			shortName: 'g',
			Required = true,
			HelpText = "Path the the file containing guest information")]
		public string? GuestsFilePath { get; set; }
		
		[Option(
			longName: "SolverType",
			shortName: 's',
			Required = false,
			Default = MixedIntegerSolver.SCIP_MIXED_INTEGER_PROGRAMMING,
			HelpText = "The solver to use")]
		public MixedIntegerSolver SolverType { get; set; }
		
		[Option(
			longName: "Threads",
			Required = false,
			Default = 0,
			HelpText = "The number of threads to use for optimization; use 0 for unrestricted")]
		public int NumThreads { get; set; }
		
		[Option(
			longName: "TimeLimit",
			Required = false,
			Default = 60,
			HelpText = "The time limit (minutes) per phase for optimization; use 0 for no limit")]
		public long TimeLimitMinutes { get; set; }
		
		[Option(
			longName: "ModelFile",
			shortName: 'm',
			Required = false,
			Default = null,
			HelpText = "Path the the where to write the LP model")]
		public string? ModelFilePath { get; set; }
		
		[Option(
			longName: "ResultsFile",
			shortName: 'r',
			Required = false,
			Default = "results.txt",
			HelpText = "Path the the where to write the results")]
		public string? ResultsFilePath { get; set; }
	}
}
