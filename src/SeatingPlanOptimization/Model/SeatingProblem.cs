namespace Ozzah.SeatingPlanOptimization.Model;

public class SeatingProblem
{
	public Solver Solver { get; }

	public Variable[,]? GuestToTable { get; set; }

	public Variable[,,]? GuestWithGuestToTable { get; set; }

	public Variable? PoorestGuestReward { get; set; }
	public Variable[]? GuestReward { get; set; }

	public Variable[]? TableUsed { get; set; }

	HashSet<Constraint> Constraints { get; } = new();

	public SeatingProblem(MixedIntegerSolver solverType)
	{
		Solver = Solver.CreateSolver(solverType.ToString());
	}

	public Constraint MakeConstraint(double lowerBound, double upperBound, string name)
	{
		var constraint = Solver.MakeConstraint(lowerBound, upperBound, name);
		Constraints.Add(constraint);
		return constraint;
	}
}
