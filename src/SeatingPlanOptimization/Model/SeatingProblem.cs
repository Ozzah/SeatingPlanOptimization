using System.Collections.Generic;
using Google.OrTools.LinearSolver;

namespace Ozzah.SeatingPlanOptimization.Model
{
	public class SeatingProblem
	{
		public Solver Solver { get; } = Solver.CreateSolver("CBC_Mixed_Integer_Programming");

		public Variable[,]? GuestToTable { get; set; }

		public Variable[,,]? GuestWithGuestToTable { get; set; }

		public HashSet<Constraint> Constraints { get; } = new();
	}
}
