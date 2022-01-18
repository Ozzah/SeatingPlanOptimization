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
			HelpText = "Path to the file containing table information")]
		public string? TablesFilePath { get; set; }

		[Option(
			longName: "GuestsFile",
			shortName: 'g',
			Required = true,
			HelpText = "Path to the file containing guest information")]
		public string? GuestsFilePath { get; set; }

		[Option(
			longName: "SolverType",
			shortName: 's',
			Required = false,
			Default = MixedIntegerSolver.SCIP_MIXED_INTEGER_PROGRAMMING,
			HelpText = "The MIP solver to use")]
		public MixedIntegerSolver SolverType { get; set; }

		[Option(
			longName: "Threads",
			Required = false,
			Default = 0,
			HelpText = "The number of threads to use for optimization; use 0 for default")]
		public int NumThreads { get; set; }

		[Option(
			longName: "TimeLimit",
			Required = false,
			Default = 60,
			HelpText = "The time limit (minutes) per phase for optimization; use 0 for no limit")]
		public long TimeLimitMinutes { get; set; }

		[Option(
			longName: "BreakSymmetry",
			Required = false,
			Default = true,
			HelpText = "Whether to introduce symmetry-breaking constraints for identical tables")]
		public bool BreakSymmetry { get; set; }

		[Option(
			longName: "PhaseOneResultsFile",
			Required = false,
			Default = null,
			HelpText = "The path to write the phase 1 results")]
		public string? Phase1ResultsFilePath { get; set; }

		[Option(
			longName: "ResultsFile",
			shortName: 'r',
			Required = false,
			Default = "results.txt",
			HelpText = "The path to write the phase 2 (final) results")]
		public string? Phase2ResultsFilePath { get; set; }

		[Option(
			longName: "PhaseTwoTolerance",
			Required = false,
			Default = 0.8,
			HelpText = "The poorest phase 1 objective value (ratio) permissible in phase 2")]
		public double Phase2Tolerances { get; set; }

		[Option(
			longName: "MipGapCutoff",
			Required = false,
			Default = 0.01,
			HelpText = "The tolerance at which the solution is considered optimal")]
		public double MipGap { get; set; }
	}
}
