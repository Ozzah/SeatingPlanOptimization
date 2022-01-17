# Seating Plan Optimization

## Description

This project is a decision support system for solving the problem of assigning guests to tables for events such as weddings. It is loosely based on my previous <sup></sup> research<sup><a href="https://link.springer.com/article/10.1007/s10878-018-0253-2">1</a>,<a href="https://www.sciencedirect.com/science/article/abs/pii/S0304397517300348">2</a></sup> on a similar problem.

The problem is solved in two phases (see: [Goal Programming](https://en.wikipedia.org/wiki/Goal_programming)):
* Phase 1: Maximise the total reward across all guests
* Phase 2: Maximise the minimum guest reward, subject to a lower bound on total reward

To solve this problem, this project can use [COIN-OR Branch-and-Cut MIP Solver](https://github.com/coin-or/Cbc) or [SCIP](https://scipopt.org/) (non-commercial/academic).

## Building

You need the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to build this project, and [.NET 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to run it.

Run `dotnet build src` from the repository root to build the project.

## Running

You can run the project after building it, using the executable that is generated in the `bin` directory, or using `dotnet run --project src/SeatingPlanOptimizaion` from the repository root.

You will need to specify some additional arguments when running the program:

---

`-t`, `--TablesFile`   **Required.** Path to the file containing table information

`-g`, `--GuestsFile`   **Required.** Path to the file containing guest information

`-s`, `--SolverType`   (Default: SCIP_MIXED_INTEGER_PROGRAMMING) The MIP solver to use

`--Threads`            (Default: 0) The number of threads to use for optimization; use 0 for default

`--TimeLimit`          (Default: 60) The time limit (minutes) per phase for optimization; use 0 for no limit

`--PhaseOneResultsFile` The path to write the phase 1 results

`-r`, `--ResultsFile`  (Default: results.txt) Tha path to write the phase 2 (final) results

`--PhaseTwoTolerance`  (Default: 0.8) The poorest phase 1 objective value (ratio) permissible in phase 2

`--MipGapCutoff`       (Default: 0.01) The tolerance at which the solution is considered optimal


---

The permissible values for `-s`/`--SolverType` are: `CBC_MIXED_INTEGER_PROGRAMMING` and `SCIP_MIXED_INTEGER_PROGRAMMING`. CBC is single-threaded and does not support early termination with <kbd>Ctrl</kbd>+<kbd>C</kbd>, however it is open source and licensed under [Eclipse Public Licence v2](https://github.com/coin-or/Cbc/blob/master/LICENSE). SCIP is multi-threaded and supports early termination, but is only for non-commercial/academic use under the [ZIB Academic License](https://scipopt.org/academic.txt) unless you [purchase a commercial license](https://scipopt.org/index.php#license) from ZIB.

The `--PhaseTwoTolerance` parameter controls how much deterioration of the Phase 1 objective value is permitted, when optimising for the Phase 2 objective. For example, if you set the `--PhaseTwoTolerance` to `0.8` (80%), and the the total guest reward in Phase 1 was 1500, then the total guest reward is not permitted to be lower than 1200 in Phase 2. The tighter the tolerance (closer to 100%), the less deterioration you are likely to see in Phase 2 w.r.t. Phase 1, but the less opportunity there is to maximise the Phase 2 objective.

The `--MipGapCutoff` controls the termination condition for the solver. A value of `0.01` means the solver will terminate when the difference between the lower bound and upper bound on the objective value is less than or equal to 1%. 

See an [Example Problem](./example/EXAMPLE.md).

### Tables File

You will need to create a tab-separated tables file that describes the minimum and maximum number of guests for each table.
The tables file should have a header row, and the first two columns should be the minimum and maximum number of guests, respectively.
Any additional columns are ignored.
You can specify as many tables as you like; any tables that are not used in the final solution will be labelled as such in the results file.

Example:

```text
Min	Max	Comment
12	15	Big table
8	10	Regular Table 1
8	10	Regular Table 2
8	10	Regular Table 3
5	8	Small Table
```

### Guests File

You will need to create a tab-separated guests file that describes the pairwise reward for matching guest `i` with guest `j`. The reward matrix should be square, and only the upper triangle is used. The matrix should be numeric, and you can use negative numbers to discourage pairing.

Example:

```text
	Alice	Bob	Eve	Mal	Carol	Dan
Alice	-	1	-1	3.5	2	3	
Bob	-	-	2	1	3	-2
Eve	-	-	-	1	4	100
Mal	-	-	-	-	6	-100
Carol	-	-	-	-	-	1
Dan	-	-	-	-	-	-
```

In the above example, Eve and Dan have a pairing reward of 100, and Mal and Dan have a reward of -100 (or, a penalty of 100).

### Infeasible Solutions

If your problem—characterised by your tables and guests—does not admit any solution, for instance because you have too many or too few tables with respect to the number of guests, then the program will alert in the following manner:

```text
E0104 12:35:56.123456 40144 linear_solver.cc:1869] No solution exists. MPSolverInterface::result_status_ = MPSOLVER_INFEASIBLE
```

### Result

The result file will show which guests should be assigned to which table. It will show the reward for each individual, as well as the reward for the table overall. At the end, the total reward is shown. Note, the per-guest, per-table, and overall rewards shown in the output file are exactly double the objective value reported by CBC, since we count the reward for guest `i` paired with guest `j`, and again the reward for guest `j` paired with guest `i`.

Optionally, you can specify the `--PhaseOneResultsFile` parameter if you also want to see the results from the first phase.

## To Do

1. Use more advanced mathematical programming techniques, such as column generation or a Lagrangian heuristic.
2. Investigate warm-start with an initial solution provided by a genetic algorithm.
