using System.Collections.Generic;
using Google.OrTools.Algorithms;
using Google.OrTools.LinearSolver;

namespace Ozzah.SeatingPlanOptimization.Model
{
	public class SeatingProblem
	{
		public Solver Solver { get; }

		public Variable[,]? GuestToTable { get; set; }

		public Variable[,,]? GuestWithGuestToTable { get; set; }

		public HashSet<Constraint> Constraints { get; } = new();

		public SeatingProblem(MixedIntegerSolver solverType)
		{
			Solver = Solver.CreateSolver(solverType.ToString());
		}
	}
}
