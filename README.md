# Seating Plan Optimization

## Description

This project is a decision support system for solving the problem of assigning guests to tables for events such as weddings. It is loosely based on my [previous](https://link.springer.com/article/10.1007/s10878-018-0253-2) [research](https://www.sciencedirect.com/science/article/abs/pii/S0304397517300348) on a similar problem.

To solve this problem, this project can use [COIN-OR Branch-and-Cut MIP Solver](https://github.com/coin-or/Cbc) or [SCIP](https://scipopt.org/) (non-commercial/academic).

## Building

You need the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to build this project, and [.NET 6 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) to run it.

Run `dotnet build src` from the repository root to build the project.

## Running

You can run the project after building it, using the executable that is generated in the `bin` directory, or using `dotnet run --project src/SeatingPlanOptimizaion` from the repository root.

You will need to specify some additional arguments when running the program:

---

`-t`, `--TablesFile`     **Required.** Path the the file containing table information

`-g`, `--GuestsFile`     **Required.** Path the the file containing guest information

`-s`, `--SolverType`     (Default: SCIP_MIXED_INTEGER_PROGRAMMING) The solver to use

`--Threads`            (Default: 0) The number of threads to use for optimization; use 0 for unrestricted

`--TimeLimit`          (Default: 60) The time limit (minutes) per phase for optimization; use 0 for no limit

`-m`, `--ModelFile`      Path the the where to write the LP model

`-r`, `--ResultsFile`    (Default: results.txt) Path the the where to write the results

---

The permissible values for `-s`/`--SolverType` are: `CBC_MIXED_INTEGER_PROGRAMMING` and `SCIP_MIXED_INTEGER_PROGRAMMING`. CBC is single-threaded and does not support early termination with <kbd>Ctrl</kbd>+<kbd>C</kbd>, however it is open source and licensed under [Eclipse Public Licence v2](https://github.com/coin-or/Cbc/blob/master/LICENSE). SCIP is multi-threaded and supports early termination, but is only for non-commercial/academic use under the [ZIB Academic License](https://scipopt.org/academic.txt) unless you [purchase a commercial license](https://scipopt.org/index.php#license) from ZIB. 

See an [Example Problem](./example/EXAMPLE.md).

### Tables File

You will need to create a tab-separated tables file that describes the minimum and maximum number of guests for each table. The tables file should have a header row, and the first two columns should be the minimum and maximum number of guests, respectively. Any additional columns are ignored.

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

## To Do

1. Use more advanced mathematical programming techniques, such as column generation or a Lagrangian heuristic.
2. Warm-start with an initial solution provided by a genetic algorithm.
3. Use goal programming: first solve the total reward maximisation problem, then solve the problem of maximising individual reward s.t. relaxed total reward. This should eliminate the situation where one unlucky individual from a clique is assigned away from their friends, for instance when the clique size is 11 but the maximum table size is 10.
