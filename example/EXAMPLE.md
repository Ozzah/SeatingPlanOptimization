# Example

## Command Line

Run `./SeatingPlanOptimization -t tables.txt -g guests.txt -s SCIP_MIXED_INTEGER_PROGRAMMING --PhaseOneResultsFile results1.txt`

## Output

```text
presolving:
(round 1, exhaustive) 0 del vars, 0 del conss, 0 add conss, 0 chg bounds, 0 chg sides, 0 chg coeffs, 10455 upgd conss, 0 impls, 6976 clqs
(round 2, exhaustive) 0 del vars, 10416 del conss, 3472 add conss, 0 chg bounds, 0 chg sides, 0 chg coeffs, 10455 upgd conss, 0 impls, 6976 clqs
(round 3, exhaustive) 0 del vars, 10416 del conss, 3472 add conss, 0 chg bounds, 0 chg sides, 0 chg coeffs, 10462 upgd conss, 0 impls, 6976 clqs
   (0.0s) probing: 1000/3703 (27.0%) - 0 fixings, 0 aggregations, 331433 implications, 0 bound changes
   (0.0s) probing: 1001/3703 (27.0%) - 0 fixings, 0 aggregations, 331804 implications, 0 bound changes
   (0.0s) probing aborted: 1000/1000 successive useless probings
   Deactivated symmetry handling methods, since SCIP was built without symmetry detector (SYM=none).
presolving (4 rounds: 4 fast, 4 medium, 4 exhaustive):
 0 deleted vars, 10416 deleted constraints, 3472 added constraints, 0 tightened bounds, 0 added holes, 0 changed sides, 0 changed coefficients
 0 implications, 24910 cliques
presolved problem has 3703 variables (3703 bin, 0 int, 0 impl, 0 cont) and 3518 constraints
     14 constraints of type <knapsack>
     32 constraints of type <setppc>
   3472 constraints of type <and>
Presolving Time: 0.00

 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  1.0s|     1 |     0 |  2736 |     - |    49M |   0 |3703 |3601 |6990 |   0 |  0 |  82 |   0 | 1.262645e+03 |      --      |    Inf | unknown
  3.0s|     1 |     0 |  7666 |     - |    50M |   0 |3703 |3711 |7153 | 163 |  1 | 192 |   0 | 1.262645e+03 |      --      |    Inf | unknown
  3.0s|     1 |     0 |  8632 |     - |    52M |   0 |3703 |3721 |7303 | 313 |  2 | 202 |   0 | 1.262645e+03 |      --      |    Inf | unknown
  3.0s|     1 |     0 | 10213 |     - |    54M |   0 |3703 |3722 |7494 | 504 |  3 | 203 |   0 | 1.262645e+03 |      --      |    Inf | unknown
  4.0s|     1 |     0 | 11719 |     - |    56M |   0 |3703 |3723 |7675 | 685 |  4 | 204 |   0 | 1.262577e+03 |      --      |    Inf | unknown
  4.0s|     1 |     0 | 12418 |     - |    58M |   0 |3703 |3733 |7749 | 759 |  5 | 214 |   0 | 1.261962e+03 |      --      |    Inf | unknown
  5.0s|     1 |     0 | 12424 |     - |    63M |   0 |3703 |3743 |7765 | 775 |  6 | 224 |   0 | 1.261961e+03 |      --      |    Inf | unknown
  5.0s|     1 |     0 | 12438 |     - |    65M |   0 |3703 |3753 |7769 | 779 |  7 | 234 |   0 | 1.261919e+03 |      --      |    Inf | unknown
  6.0s|     1 |     0 | 13442 |     - |    69M |   0 |3703 |3763 |7828 | 838 |  8 | 244 |   0 | 1.261729e+03 |      --      |    Inf | unknown
  6.0s|     1 |     0 | 14421 |     - |    71M |   0 |3703 |3764 |7882 | 892 |  9 | 245 |   0 | 1.261211e+03 |      --      |    Inf | unknown
  6.0s|     1 |     0 | 14617 |     - |    75M |   0 |3703 |3767 |7884 | 894 | 10 | 248 |   0 | 1.260516e+03 |      --      |    Inf | unknown
  6.0s|     1 |     0 | 14706 |     - |    76M |   0 |3703 |3775 |7886 | 896 | 11 | 256 |   0 | 1.259940e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16138 |     - |    77M |   0 |3703 |3784 |8000 |1010 | 12 | 265 |   0 | 1.259647e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16254 |     - |    78M |   0 |3703 |3792 |8002 |1012 | 13 | 273 |   0 | 1.259462e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16450 |     - |    79M |   0 |3703 |3793 |8006 |1016 | 14 | 274 |   0 | 1.259069e+03 |      --      |    Inf | unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  7.0s|     1 |     0 | 16798 |     - |    80M |   0 |3703 |3801 |8030 |1040 | 15 | 282 |   0 | 1.259000e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16813 |     - |    80M |   0 |3703 |3811 |7964 |1073 | 16 | 292 |   0 | 1.258963e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16847 |     - |    81M |   0 |3703 |3821 |7965 |1074 | 17 | 302 |   0 | 1.258904e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 16928 |     - |    83M |   0 |3703 |3831 |7966 |1075 | 18 | 312 |   0 | 1.258736e+03 |      --      |    Inf | unknown
  7.0s|     1 |     0 | 17008 |     - |    83M |   0 |3703 |3841 |7967 |1076 | 19 | 322 |   0 | 1.258720e+03 |      --      |    Inf | unknown
d 8.0s|     1 |     0 | 19637 |     - |farkasdi|   0 |3703 |3854 |7967 |   0 | 21 | 335 |   0 | 1.258720e+03 | 6.971283e+02 |  80.56%| unknown
  8.0s|     1 |     0 | 21392 |     - |    84M |   0 |3703 |3906 |7967 |1076 | 21 | 387 |   0 | 1.258720e+03 | 6.971283e+02 |  80.56%| unknown
  8.0s|     1 |     0 | 21537 |     - |    85M |   0 |3703 |3916 |7885 |1078 | 22 | 397 |   0 | 1.258694e+03 | 6.971283e+02 |  80.55%| unknown
  8.0s|     1 |     0 | 21636 |     - |    85M |   0 |3703 |3926 |7886 |1079 | 23 | 407 |   0 | 1.258671e+03 | 6.971283e+02 |  80.55%| unknown
 10.0s|     1 |     2 | 21636 |     - |    85M |   0 |3703 |3927 |7886 |1079 | 23 | 408 |  11 | 1.258219e+03 | 6.971283e+02 |  80.49%| unknown
o88.0s|    30 |    31 |119694 |3532.5 |rootsold|   7 |3703 |3939 |8500 |5721 |  2 | 450 | 433 | 1.241787e+03 | 1.023782e+03 |  21.29%| unknown
d 108s|    47 |    48 |179733 |3532.2 |adaptive|   8 |3703 |4499 |9282 |   0 |  6 |1010 | 487 | 1.230695e+03 | 1.033602e+03 |  19.07%| unknown
r 114s|    57 |    40 |197001 |3209.8 |shifting|  10 |3703 |3990 |9315 |8349 |  2 |1130 | 509 | 1.230695e+03 | 1.136400e+03 |   8.30%|  10.75%
  143s|   100 |    51 |268239 |2535.2 |   116M |  13 |3703 |4518 |9373 |  11k|  0 |1683 | 632 | 1.227303e+03 | 1.136400e+03 |   8.00%|  20.96%
  223s|   200 |    81 |450970 |2179.5 |   162M |  15 |3703 |6219 |9026 |  21k|  5 |3872 |1093 | 1.210897e+03 | 1.136400e+03 |   6.56%|  45.16%
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  312s|   300 |    96 |644510 |2097.9 |   209M |  19 |3703 |7443 |9406 |  28k|  3 |6800 |1577 | 1.204797e+03 | 1.136400e+03 |   6.02%|  52.19%
* 349s|   350 |    81 |723840 |2024.6 |strongbr|  21 |3703 |7495 |  10k|  31k|  3 |8226 |1826 | 1.196429e+03 | 1.138638e+03 |   5.08%|  61.10%
  379s|   400 |    77 |783115 |1919.5 |   231M |  21 |3703 |7584 |9973 |  34k|  0 |9468 |2093 | 1.194243e+03 | 1.138638e+03 |   4.88%|  65.40%
  464s|   500 |    71 |952052 |1873.3 |   272M |  23 |3703 |7280 |  10k|  39k|  5 |  12k|2592 | 1.190691e+03 | 1.138638e+03 |   4.57%|  75.14%
  519s|   600 |    63 |  1058k|1738.0 |   302M |  23 |3703 |7019 |  10k|  43k|  0 |  15k|2972 | 1.185533e+03 | 1.138638e+03 |   4.12%|  82.11%
  591s|   700 |    41 |  1189k|1677.0 |   317M |  23 |3703 |7225 |  11k|  48k|  4 |  18k|3602 | 1.182148e+03 | 1.138638e+03 |   3.82%|  88.55%
  647s|   800 |    27 |  1309k|1617.5 |   335M |  24 |3703 |6899 |  10k|  52k| 15 |  21k|4002 | 1.174877e+03 | 1.138638e+03 |   3.18%|  92.57%
  714s|   900 |    15 |  1422k|1563.6 |   342M |  29 |3703 |8034 |  12k|  56k|  0 |  25k|4569 | 1.171138e+03 | 1.138638e+03 |   2.85%|  96.04%
  767s|  1000 |     7 |  1502k|1486.6 |   363M |  29 |3703 |8177 |  10k|  59k|  0 |  28k|5069 | 1.156298e+03 | 1.138638e+03 |   1.55%|  98.98%

SCIP Status        : solving was interrupted [gap limit reached]
Solving Time (sec) : 788.00
Solving Nodes      : 1042
Primal Bound       : +1.13863765362700e+03 (64 solutions)
Dual Bound         : +1.14731225772913e+03
Gap                : 0.76 %
feasible solution found by completesol heuristic after 0.0 seconds, objective value 5.228878e+01
presolving:
(round 1, fast)       32 del vars, 32 del conss, 32 add conss, 67 chg bounds, 0 chg sides, 0 chg coeffs, 0 upgd conss, 0 impls, 6976 clqs
(round 2, fast)       32 del vars, 64 del conss, 32 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 0 upgd conss, 0 impls, 6976 clqs
(round 3, exhaustive) 32 del vars, 64 del conss, 32 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 10455 upgd conss, 0 impls, 6976 clqs
(round 4, exhaustive) 32 del vars, 10480 del conss, 3504 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 10455 upgd conss, 0 impls, 6976 clqs
(round 5, exhaustive) 32 del vars, 10480 del conss, 3504 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 10462 upgd conss, 0 impls, 6976 clqs
(round 6, exhaustive) 57 del vars, 10480 del conss, 3504 add conss, 69 chg bounds, 0 chg sides, 0 chg coeffs, 10462 upgd conss, 27 impls, 16818 clqs
(round 7, exhaustive) 57 del vars, 10505 del conss, 3529 add conss, 69 chg bounds, 0 chg sides, 0 chg coeffs, 10462 upgd conss, 27 impls, 16818 clqs
(round 8, exhaustive) 82 del vars, 10505 del conss, 3529 add conss, 69 chg bounds, 0 chg sides, 0 chg coeffs, 10462 upgd conss, 52 impls, 24528 clqs
(round 9, fast)       82 del vars, 10509 del conss, 3529 add conss, 69 chg bounds, 0 chg sides, 2 chg coeffs, 10462 upgd conss, 52 impls, 24528 clqs
(round 10, exhaustive) 201 del vars, 10647 del conss, 3548 add conss, 69 chg bounds, 0 chg sides, 2 chg coeffs, 10462 upgd conss, 52 impls, 23717 clqs
(round 11, exhaustive) 226 del vars, 10647 del conss, 3548 add conss, 69 chg bounds, 0 chg sides, 2 chg coeffs, 10462 upgd conss, 78 impls, 27594 clqs
(round 12, fast)       226 del vars, 10655 del conss, 3548 add conss, 69 chg bounds, 0 chg sides, 3 chg coeffs, 10462 upgd conss, 78 impls, 27594 clqs
(round 13, exhaustive) 459 del vars, 10904 del conss, 3564 add conss, 69 chg bounds, 0 chg sides, 3 chg coeffs, 10462 upgd conss, 78 impls, 25693 clqs
(round 14, exhaustive) 484 del vars, 10904 del conss, 3564 add conss, 70 chg bounds, 0 chg sides, 3 chg coeffs, 10462 upgd conss, 104 impls, 26811 clqs
(round 15, fast)       484 del vars, 10919 del conss, 3564 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 10462 upgd conss, 104 impls, 26811 clqs
(round 16, exhaustive) 894 del vars, 11338 del conss, 3573 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 10462 upgd conss, 104 impls, 23298 clqs
(round 17, exhaustive) 919 del vars, 11338 del conss, 3573 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 10462 upgd conss, 127 impls, 26073 clqs
(round 18, fast)       919 del vars, 11350 del conss, 3573 add conss, 70 chg bounds, 0 chg sides, 5 chg coeffs, 10462 upgd conss, 127 impls, 26073 clqs
(round 19, exhaustive) 1217 del vars, 11660 del conss, 3585 add conss, 70 chg bounds, 0 chg sides, 5 chg coeffs, 10462 upgd conss, 127 impls, 22690 clqs
(round 20, exhaustive) 1242 del vars, 11661 del conss, 3585 add conss, 70 chg bounds, 0 chg sides, 5 chg coeffs, 10462 upgd conss, 148 impls, 26081 clqs
(round 21, fast)       1242 del vars, 11671 del conss, 3585 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 10462 upgd conss, 148 impls, 26081 clqs
(round 22, exhaustive) 1488 del vars, 11931 del conss, 3599 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 10462 upgd conss, 148 impls, 23126 clqs
(round 23, fast)       1488 del vars, 11933 del conss, 3599 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 10462 upgd conss, 148 impls, 23126 clqs
(round 24, exhaustive) 1513 del vars, 11933 del conss, 3599 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 10462 upgd conss, 173 impls, 25005 clqs
(round 25, fast)       1513 del vars, 11954 del conss, 3599 add conss, 70 chg bounds, 0 chg sides, 8 chg coeffs, 10462 upgd conss, 173 impls, 25005 clqs
(round 26, exhaustive) 1939 del vars, 12383 del conss, 3602 add conss, 70 chg bounds, 0 chg sides, 8 chg coeffs, 10462 upgd conss, 173 impls, 19666 clqs
(round 27, exhaustive) 1964 del vars, 12383 del conss, 3602 add conss, 70 chg bounds, 0 chg sides, 8 chg coeffs, 10462 upgd conss, 200 impls, 20860 clqs
(round 28, fast)       1964 del vars, 12414 del conss, 3602 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10462 upgd conss, 200 impls, 20860 clqs
(round 29, exhaustive) 2407 del vars, 12859 del conss, 3604 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10462 upgd conss, 200 impls, 15143 clqs
(round 30, exhaustive) 2432 del vars, 12860 del conss, 3604 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10462 upgd conss, 306 impls, 27563 clqs
(round 31, fast)       2432 del vars, 12872 del conss, 3604 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10464 upgd conss, 306 impls, 27563 clqs
(round 32, exhaustive) 2552 del vars, 13006 del conss, 3615 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10464 upgd conss, 310 impls, 24895 clqs
(round 33, exhaustive) 2577 del vars, 13006 del conss, 3615 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10464 upgd conss, 744 impls, 25685 clqs
(round 34, fast)       2577 del vars, 13006 del conss, 3615 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10481 upgd conss, 744 impls, 25685 clqs
   (1.0s) probing: 1000/3703 (27.0%) - 24 fixings, 232 aggregations, 548447 implications, 2 bound changes
   (1.0s) probing: 2000/3703 (54.0%) - 32 fixings, 232 aggregations, 808872 implications, 2 bound changes
   (1.0s) probing: 3000/3703 (81.0%) - 32 fixings, 232 aggregations, 808872 implications, 2 bound changes
   (1.0s) probing cycle finished: starting next cycle
(round 35, exhaustive) 2602 del vars, 13006 del conss, 3615 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 10481 upgd conss, 1254 impls, 26894 clqs
(round 36, fast)       2602 del vars, 13016 del conss, 3615 add conss, 70 chg bounds, 8 chg sides, 145 chg coeffs, 10494 upgd conss, 1254 impls, 26894 clqs
(round 37, fast)       2602 del vars, 13017 del conss, 3615 add conss, 70 chg bounds, 8 chg sides, 145 chg coeffs, 10494 upgd conss, 1254 impls, 26906 clqs
(round 38, exhaustive) 2748 del vars, 13173 del conss, 3616 add conss, 70 chg bounds, 8 chg sides, 145 chg coeffs, 10494 upgd conss, 1254 impls, 23174 clqs
(round 39, exhaustive) 2773 del vars, 13173 del conss, 3616 add conss, 70 chg bounds, 8 chg sides, 145 chg coeffs, 10494 upgd conss, 1254 impls, 26223 clqs
(round 40, fast)       2773 del vars, 13182 del conss, 3616 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10504 upgd conss, 1254 impls, 26223 clqs
(round 41, exhaustive) 2775 del vars, 13187 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10504 upgd conss, 1254 impls, 26152 clqs
(round 42, fast)       2775 del vars, 13189 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10504 upgd conss, 1254 impls, 26153 clqs
(round 43, exhaustive) 2827 del vars, 13245 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10504 upgd conss, 1254 impls, 24414 clqs
(round 44, exhaustive) 2852 del vars, 13245 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10504 upgd conss, 1254 impls, 27152 clqs
(round 45, fast)       2852 del vars, 13245 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10525 upgd conss, 1254 impls, 27152 clqs
   (1.0s) probing: 1000/1144 (87.4%) - 72 fixings, 264 aggregations, 966322 implications, 2 bound changes
   (1.0s) probing cycle finished: starting next cycle
(round 46, exhaustive) 2877 del vars, 13245 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10525 upgd conss, 1254 impls, 26901 clqs
(round 47, fast)       2877 del vars, 13273 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10536 upgd conss, 1254 impls, 26901 clqs
(round 48, fast)       2877 del vars, 13279 del conss, 3621 add conss, 70 chg bounds, 14 chg sides, 247 chg coeffs, 10536 upgd conss, 1254 impls, 26906 clqs
(round 49, exhaustive) 2934 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 249 chg coeffs, 10536 upgd conss, 1254 impls, 24759 clqs
(round 50, exhaustive) 2959 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 249 chg coeffs, 10536 upgd conss, 1254 impls, 27290 clqs
(round 51, fast)       2959 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 249 chg coeffs, 10561 upgd conss, 1254 impls, 27290 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 52, exhaustive) 2979 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 249 chg coeffs, 10561 upgd conss, 1254 impls, 27227 clqs
(round 53, fast)       2979 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 249 chg coeffs, 10581 upgd conss, 1254 impls, 27227 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 54, exhaustive) 2988 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 250 chg coeffs, 10581 upgd conss, 1254 impls, 28028 clqs
(round 55, fast)       2988 del vars, 13353 del conss, 3623 add conss, 70 chg bounds, 14 chg sides, 250 chg coeffs, 10590 upgd conss, 1254 impls, 28028 clqs
   (2.0s) probing cycle finished: starting next cycle
   Deactivated symmetry handling methods, since SCIP was built without symmetry detector (SYM=none).
presolving (56 rounds: 56 fast, 34 medium, 34 exhaustive):
 2988 deleted vars, 13353 deleted constraints, 3623 added constraints, 70 tightened bounds, 0 added holes, 14 changed sides, 251 changed coefficients
 1254 implications, 28744 cliques
presolved problem has 748 variables (747 bin, 0 int, 0 impl, 1 cont) and 797 constraints
     14 constraints of type <knapsack>
    115 constraints of type <setppc>
    635 constraints of type <and>
     33 constraints of type <linear>
Presolving Time: 2.00
transformed 1/1 original solutions to the transformed problem space

 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  2.0s|     1 |     0 |   325 |     - |    43M |   0 | 748 | 881 |1432 |   0 |  0 |  83 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |   325 |     - |    43M |   0 | 748 | 886 |1432 |   0 |  0 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |   457 |     - |    43M |   0 | 748 | 886 |1474 |  42 |  1 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |   637 |     - |    45M |   0 | 748 | 886 |1510 |  78 |  2 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |   754 |     - |    45M |   0 | 748 | 886 |1540 | 108 |  3 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |  1006 |     - |    46M |   0 | 748 | 886 |1580 | 148 |  4 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |  1240 |     - |    47M |   0 | 748 | 886 |1617 | 185 |  5 |  88 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |  1445 |     - |    48M |   0 | 748 | 887 |1656 | 224 |  6 |  89 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |  1594 |     - |    49M |   0 | 748 | 897 |1669 | 237 |  7 |  99 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  2.0s|     1 |     0 |  1793 |     - |    50M |   0 | 748 | 899 |1682 | 250 |  8 | 101 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  3.0s|     1 |     0 |  1870 |     - |    52M |   0 | 748 | 899 |1699 | 267 |  9 | 101 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  3.0s|     1 |     0 |  1972 |     - |    52M |   0 | 748 | 900 |1717 | 285 | 10 | 102 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  3.0s|     1 |     0 |  2237 |     - |    53M |   0 | 748 | 900 |1708 | 293 | 11 | 102 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
  3.0s|     1 |     0 |  2394 |     - |    53M |   0 | 748 | 901 |1722 | 307 | 12 | 103 |   0 | 5.716143e+01 | 5.228878e+01 |   9.32%| unknown
d 3.0s|     1 |     0 |  3874 |     - |conflict|   0 | 748 | 901 |1722 |   0 | 12 | 103 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  3.0s|     1 |     0 |  3874 |     - |    53M |   0 | 748 | 901 |1722 | 307 | 12 | 103 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  3874 |     - |    53M |   0 | 748 | 902 |1720 | 307 | 12 | 104 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  4020 |     - |    53M |   0 | 748 | 902 |1728 | 315 | 13 | 104 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  4230 |     - |    53M |   0 | 748 | 902 |1735 | 322 | 14 | 104 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  4230 |     - |    53M |   0 | 748 | 906 |1737 | 322 | 14 | 109 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  4310 |     - |    53M |   0 | 748 | 906 |1751 | 336 | 15 | 109 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     0 |  4354 |     - |    53M |   0 | 748 | 906 |1754 | 339 | 16 | 109 |   0 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
  3.0s|     1 |     2 |  4354 |     - |    54M |   0 | 748 | 906 |1754 | 339 | 16 | 109 |  20 | 5.716143e+01 | 5.254057e+01 |   8.79%| unknown
* 5.0s|    21 |    10 |  8763 | 294.4 |    LP  |  14 | 748 | 935 |1996 | 752 |  1 | 138 | 201 | 5.716143e+01 | 5.303770e+01 |   7.78%|   4.97%
* 6.0s|    58 |     8 | 12209 | 163.8 |    LP  |  14 | 748 | 955 |1878 | 967 |  1 | 177 | 255 | 5.716143e+01 | 5.568152e+01 |   2.66%|  18.49%
r 6.0s|    87 |     5 | 12777 | 115.2 |ziroundi|  18 | 748 | 958 |1889 | 999 |  1 | 196 | 255 | 5.716143e+01 | 5.600000e+01 |   2.07%|  19.00%
  7.0s|   100 |     6 | 14708 | 119.5 |    57M |  18 | 748 |1005 |1774 |1107 |  3 | 244 | 285 | 5.716143e+01 | 5.600000e+01 |   2.07%|  24.94%

SCIP Status        : solving was interrupted [gap limit reached]
Solving Time (sec) : 10.00
Solving Nodes      : 179
Primal Bound       : +5.59999999999999e+01 (5 solutions)
Dual Bound         : +5.65142658479623e+01
Gap                : 0.92 %
```

## Solution

### Phase One

```text
TABLE 1 (232)
	Mason (60)
	Camila (56)
	Michael (56)
	Gianna (60)

TABLE 2 (UNUSED)

TABLE 3 (UNUSED)

TABLE 4 (471.398712904)
	James (61.940479551)
	Amelia (56)
	Benjamin (57.758876901)
	Isabella (60)
	Alan (60)
	Heza (56)
	David (58.452903817999996)
	Katrina (61.246452634)

TABLE 5 (662.2925433519999)
	Liam (65)
	Olivia (63.528502194999994)
	Noah (59.03769556)
	Emma (77.580073921)
	Oliver (76)
	Ava (59.03769556)
	Elijah (71)
	Charlotte (73.207102707)
	William (57.580073921)
	Sophia (60.321399488)

TABLE 6 (UNUSED)

TABLE 7 (753.944276858)
	Lucas (65)
	Mia (61)
	Henry (65.184061146)
	Evelyn (66)
	Alexander (69.247505058)
	Harper (57.540572225)
	Sam (76.72463337100001)
	Frances (110)
	Oliver (113.247505058)
	Anastasia (70)

Solution Value: 2119.635533114
```

## Phase Two

```text
TABLE 1 (UNUSED)

TABLE 2 (370.07539111999995)
	Liam (65)
	Olivia (61)
	Noah (59.03769556)
	Emma (66)
	Oliver (66)
	Ava (53.03769556)

TABLE 3 (UNUSED)

TABLE 4 (696.762801268)
	Sam (66.499694416)
	Frances (109.88170621799999)
	Oliver (150)
	Anastasia (86)
	Alan (66.09916386)
	Heza (71)
	David (71)
	Katrina (76.282236774)

TABLE 5 (708.353517492)
	Elijah (70.17675874599999)
	Charlotte (66)
	William (66)
	Sophia (66)
	James (86)
	Amelia (86)
	Benjamin (66.415724894)
	Isabella (65.761033852)
	Lucas (66)
	Mia (70)

TABLE 6 (502.08359737399996)
	Henry (56.753017101)
	Evelyn (66)
	Alexander (66)
	Harper (57.288781586)
	Mason (72.753017101)
	Camila (71)
	Michael (52.288781586)
	Gianna (60)

TABLE 7 (UNUSED)

Solution Value: 2277.275307254
```

## Observations

Observe that the total pairing reward in the first phase was 2277.28, and the total pairing reward in the second phase was 2119.64 (93.1%, with an 80% tolerance).

The minimum pairing reward in the first phase was for Micahel, with a reward of 52.2888. The minimum pairing reward for the second phase was 56. The minimum pairing reward was improved by 7.1%.
