# Example

## Command Line

Run `./SeatingPlanOptimization -t tables.txt -g guests.txt -s SCIP_MIXED_INTEGER_PROGRAMMING --PhaseOneResultsFile results1.txt`

## Output

```text
presolving:
(round 1, exhaustive) 0 del vars, 0 del conss, 0 add conss, 0 chg bounds, 0 chg sides, 0 chg coeffs, 7472 upgd conss, 0 impls, 4992 clqs
(round 2, exhaustive) 0 del vars, 7440 del conss, 2480 add conss, 0 chg bounds, 0 chg sides, 0 chg coeffs, 7472 upgd conss, 0 impls, 4992 clqs
   (0.0s) probing: 1000/2640 (37.9%) - 0 fixings, 0 aggregations, 227026 implications, 0 bound changes
   (0.0s) probing: 1001/2640 (37.9%) - 0 fixings, 0 aggregations, 227272 implications, 0 bound changes
   (0.0s) probing aborted: 1000/1000 successive useless probings
   Deactivated symmetry handling methods, since SCIP was built without symmetry detector (SYM=none).
presolving (3 rounds: 3 fast, 3 medium, 3 exhaustive):
 0 deleted vars, 7440 deleted constraints, 2480 added constraints, 0 tightened bounds, 0 added holes, 0 changed sides, 0 changed coefficients
 0 implications, 17632 cliques
presolved problem has 2640 variables (2640 bin, 0 int, 0 impl, 0 cont) and 2517 constraints
     32 constraints of type <setppc>
   2480 constraints of type <and>
      5 constraints of type <linear>
Presolving Time: 0.00

 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
p 0.0s|     1 |     0 |     0 |     - |shiftand|   0 |2640 |2566 |4997 |   0 |  0 |  48 |   0 | 6.313226e+03 | 9.049948e+02 | 597.60%| unknown
  0.0s|     1 |     0 |  2190 |     - |    36M |   0 |2640 |2566 |4997 |   0 |  0 |  48 |   0 | 1.262645e+03 | 9.049948e+02 |  39.52%| unknown
  2.0s|     1 |     0 |  2438 |     - |    40M |   0 |2640 |2632 |5162 | 165 |  1 | 114 |   0 | 1.262645e+03 | 9.049948e+02 |  39.52%| unknown
  2.0s|     1 |     0 |  2632 |     - |    41M |   0 |2640 |2642 |5288 | 291 |  2 | 124 |   0 | 1.262645e+03 | 9.049948e+02 |  39.52%| unknown
  2.0s|     1 |     0 |  2979 |     - |    42M |   0 |2640 |2652 |5409 | 412 |  3 | 134 |   0 | 1.262645e+03 | 9.049948e+02 |  39.52%| unknown
  2.0s|     1 |     0 |  3580 |     - |    45M |   0 |2640 |2653 |5555 | 558 |  4 | 135 |   0 | 1.262030e+03 | 9.049948e+02 |  39.45%| unknown
  2.0s|     1 |     0 |  3624 |     - |    48M |   0 |2640 |2653 |5653 | 656 |  5 | 135 |   0 | 1.261914e+03 | 9.049948e+02 |  39.44%| unknown
  2.0s|     1 |     0 |  3648 |     - |    52M |   0 |2640 |2655 |5655 | 658 |  6 | 137 |   0 | 1.261763e+03 | 9.049948e+02 |  39.42%| unknown
  3.0s|     1 |     0 |  4380 |     - |    53M |   0 |2640 |2665 |5688 | 691 |  7 | 147 |   0 | 1.261514e+03 | 9.049948e+02 |  39.39%| unknown
  3.0s|     1 |     0 |  4458 |     - |    54M |   0 |2640 |2675 |5690 | 693 |  8 | 157 |   0 | 1.261090e+03 | 9.049948e+02 |  39.35%| unknown
  3.0s|     1 |     0 |  4526 |     - |    57M |   0 |2640 |2675 |5691 | 694 |  9 | 157 |   0 | 1.260871e+03 | 9.049948e+02 |  39.32%| unknown
  3.0s|     1 |     0 |  5210 |     - |    57M |   0 |2640 |2675 |5719 | 722 | 10 | 157 |   0 | 1.260601e+03 | 9.049948e+02 |  39.29%| unknown
  3.0s|     1 |     0 |  5327 |     - |    58M |   0 |2640 |2675 |5689 | 724 | 12 | 157 |   0 | 1.260432e+03 | 9.049948e+02 |  39.28%| unknown
  4.0s|     1 |     0 |  5361 |     - |    59M |   0 |2640 |2685 |5691 | 726 | 13 | 167 |   0 | 1.260369e+03 | 9.049948e+02 |  39.27%| unknown
  4.0s|     1 |     0 |  5639 |     - |    59M |   0 |2640 |2685 |5693 | 728 | 14 | 167 |   0 | 1.260234e+03 | 9.049948e+02 |  39.25%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  4.0s|     1 |     0 |  5754 |     - |    59M |   0 |2640 |2695 |5694 | 729 | 15 | 177 |   0 | 1.260209e+03 | 9.049948e+02 |  39.25%| unknown
  4.0s|     1 |     0 |  5952 |     - |    60M |   0 |2640 |2705 |5696 | 731 | 16 | 187 |   0 | 1.260153e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6257 |     - |    60M |   0 |2640 |2715 |5698 | 733 | 17 | 197 |   0 | 1.260119e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6281 |     - |    61M |   0 |2640 |2715 |5593 | 735 | 18 | 197 |   0 | 1.260103e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6408 |     - |    61M |   0 |2640 |2716 |5595 | 737 | 19 | 198 |   0 | 1.260097e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6431 |     - |    62M |   0 |2640 |2717 |5596 | 738 | 20 | 199 |   0 | 1.260092e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6469 |     - |    62M |   0 |2640 |2717 |5597 | 739 | 21 | 199 |   0 | 1.260089e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6585 |     - |    62M |   0 |2640 |2718 |5598 | 740 | 22 | 200 |   0 | 1.260088e+03 | 9.049948e+02 |  39.24%| unknown
  4.0s|     1 |     0 |  6608 |     - |    62M |   0 |2640 |2719 |5599 | 741 | 23 | 201 |   0 | 1.260088e+03 | 9.049948e+02 |  39.24%| unknown
 12.0s|     1 |     2 | 13022 |     - |    63M |   0 |2640 |2761 |5599 | 741 | 24 | 243 |  32 | 1.255284e+03 | 9.049948e+02 |  38.71%| unknown
r25.0s|     9 |     8 | 31648 |3130.0 |rounding|   8 |2640 |2761 |6871 |2118 |  1 | 243 | 211 | 1.255284e+03 | 9.068498e+02 |  38.42%| unknown
*25.0s|     9 |     8 | 31667 |3132.4 |strongbr|   8 |2640 |2721 |6881 |2128 |  3 | 243 | 213 | 1.255284e+03 | 1.003044e+03 |  25.15%| unknown
*26.0s|    11 |     6 | 31963 |2535.5 |    LP  |   9 |2640 |2721 |6876 |2156 |  3 | 243 | 240 | 1.255284e+03 | 1.021163e+03 |  22.93%|   2.77%
*37.0s|    16 |     9 | 45982 |2624.9 |strongbr|   9 |2640 |2721 |6739 |3134 |  6 | 243 | 354 | 1.240844e+03 | 1.078287e+03 |  15.08%|   3.62%
*42.0s|    17 |    10 | 48352 |2609.0 |    LP  |   9 |2640 |2757 |6866 |3261 |  5 | 279 | 432 | 1.240844e+03 | 1.081466e+03 |  14.74%|   3.62%
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
r46.0s|    24 |     9 | 53248 |2027.8 |rounding|   9 |2640 |2834 |6982 |3562 |  7 | 356 | 532 | 1.240844e+03 | 1.083823e+03 |  14.49%|   7.38%
*49.0s|    29 |     8 | 57121 |1804.0 |strongbr|  10 |2640 |2896 |7061 |3801 |  8 | 418 | 608 | 1.240844e+03 | 1.096544e+03 |  13.16%|   8.28%
*68.0s|    78 |    21 |114119 |1396.2 |    LP  |  15 |2640 |3122 |7217 |6789 |  3 | 644 | 740 | 1.197122e+03 | 1.098674e+03 |   8.96%|  17.20%
r75.0s|    96 |    21 |132697 |1327.3 |rounding|  15 |2640 |3122 |7215 |7256 |  0 | 644 | 755 | 1.196795e+03 | 1.100632e+03 |   8.74%|  19.59%
 75.0s|   100 |    21 |133050 |1277.2 |    90M |  15 |2640 |3122 |7224 |7272 |  3 | 644 | 755 | 1.196795e+03 | 1.100632e+03 |   8.74%|  20.01%
*83.0s|   133 |    20 |152711 |1106.8 |    LP  |  15 |2640 |3263 |7021 |8540 |  2 | 785 | 821 | 1.196795e+03 | 1.102461e+03 |   8.56%|  24.51%
*85.0s|   155 |    18 |157019 | 976.7 |    LP  |  15 |2640 |3270 |7148 |8866 |  2 | 792 | 831 | 1.196795e+03 | 1.103254e+03 |   8.48%|  26.09%
r87.0s|   166 |    21 |161942 | 941.4 |rounding|  15 |2640 |3307 |7173 |9166 |  0 | 829 | 850 | 1.196795e+03 | 1.104419e+03 |   8.36%|  26.80%
 96.0s|   200 |    21 |185656 | 899.7 |   121M |  16 |2640 |3420 |7091 |  10k|  3 | 942 | 910 | 1.188489e+03 | 1.104419e+03 |   7.61%|  32.01%
d 115s|   289 |    30 |244938 | 827.5 |guideddi|  16 |2640 |3677 |7352 |   0 |  3 |1205 |1027 | 1.188197e+03 | 1.104596e+03 |   7.57%|  37.30%
* 115s|   290 |    27 |244951 | 824.7 |    LP  |  16 |2640 |3676 |7330 |  13k|  2 |1205 |1027 | 1.188197e+03 | 1.107311e+03 |   7.30%|  37.31%
  117s|   300 |    25 |251067 | 817.6 |   140M |  16 |2640 |3692 |7368 |  13k|  0 |1224 |1042 | 1.185499e+03 | 1.107311e+03 |   7.06%|  38.29%
  138s|   400 |    27 |315033 | 773.0 |   172M |  18 |2640 |3809 |7579 |  16k|  3 |1352 |1136 | 1.183726e+03 | 1.107311e+03 |   6.90%|  43.39%
r 153s|   454 |    27 |353716 | 766.2 |rounding|  18 |2640 |4094 |7391 |  19k|  0 |1708 |1251 | 1.183726e+03 | 1.114596e+03 |   6.20%|  45.10%
  164s|   500 |    27 |379449 | 747.2 |   196M |  18 |2640 |4314 |7276 |  20k|  3 |1969 |1337 | 1.178064e+03 | 1.114596e+03 |   5.69%|  48.85%
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  193s|   600 |    23 |460174 | 757.2 |   219M |  18 |2640 |4667 |7443 |  25k|  0 |2487 |1540 | 1.173494e+03 | 1.114596e+03 |   5.28%|  55.74%
  235s|   700 |    15 |573031 | 810.3 |   252M |  18 |2640 |5224 |7255 |  30k|  0 |3449 |1844 | 1.167955e+03 | 1.114596e+03 |   4.79%|  70.05%
  280s|   800 |     7 |693066 | 859.1 |   279M |  18 |2640 |6443 |7373 |  37k|  0 |5144 |2254 | 1.167518e+03 | 1.114596e+03 |   4.75%|  81.92%

SCIP Status        : solving was interrupted [gap limit reached]
Solving Time (sec) : 304.00
Solving Nodes      : 891
Primal Bound       : +1.11459585494000e+03 (77 solutions)
Dual Bound         : +1.12530861473249e+03
Gap                : 0.96 %
feasible solution found by completesol heuristic after 0.0 seconds, objective value 5.303770e+01
presolving:
(round 1, fast)       32 del vars, 32 del conss, 32 add conss, 67 chg bounds, 0 chg sides, 0 chg coeffs, 0 upgd conss, 0 impls, 4992 clqs
(round 2, fast)       32 del vars, 64 del conss, 32 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 0 upgd conss, 0 impls, 4992 clqs
(round 3, exhaustive) 32 del vars, 64 del conss, 32 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 7472 upgd conss, 0 impls, 4992 clqs
(round 4, exhaustive) 32 del vars, 7504 del conss, 2512 add conss, 68 chg bounds, 0 chg sides, 0 chg coeffs, 7472 upgd conss, 0 impls, 4992 clqs
(round 5, exhaustive) 57 del vars, 7504 del conss, 2512 add conss, 70 chg bounds, 0 chg sides, 0 chg coeffs, 7472 upgd conss, 26 impls, 11024 clqs
(round 6, exhaustive) 87 del vars, 7558 del conss, 2535 add conss, 70 chg bounds, 0 chg sides, 1 chg coeffs, 7472 upgd conss, 26 impls, 10901 clqs
(round 7, exhaustive) 112 del vars, 7558 del conss, 2535 add conss, 70 chg bounds, 0 chg sides, 1 chg coeffs, 7472 upgd conss, 53 impls, 15290 clqs
(round 8, fast)       112 del vars, 7566 del conss, 2535 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 7472 upgd conss, 53 impls, 15290 clqs
(round 9, exhaustive) 345 del vars, 7813 del conss, 2549 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 7472 upgd conss, 53 impls, 13872 clqs
(round 10, exhaustive) 370 del vars, 7813 del conss, 2549 add conss, 70 chg bounds, 0 chg sides, 4 chg coeffs, 7472 upgd conss, 81 impls, 17744 clqs
(round 11, fast)       370 del vars, 7822 del conss, 2549 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 7472 upgd conss, 81 impls, 17744 clqs
(round 12, exhaustive) 619 del vars, 8085 del conss, 2563 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 7472 upgd conss, 81 impls, 15839 clqs
(round 13, exhaustive) 644 del vars, 8085 del conss, 2563 add conss, 70 chg bounds, 0 chg sides, 6 chg coeffs, 7472 upgd conss, 106 impls, 18197 clqs
(round 14, fast)       644 del vars, 8095 del conss, 2563 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 7472 upgd conss, 106 impls, 18197 clqs
(round 15, exhaustive) 903 del vars, 8366 del conss, 2575 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 7472 upgd conss, 106 impls, 15744 clqs
(round 16, exhaustive) 928 del vars, 8367 del conss, 2575 add conss, 70 chg bounds, 0 chg sides, 9 chg coeffs, 7472 upgd conss, 126 impls, 16747 clqs
(round 17, fast)       928 del vars, 8384 del conss, 2575 add conss, 70 chg bounds, 0 chg sides, 10 chg coeffs, 7472 upgd conss, 126 impls, 16747 clqs
(round 18, exhaustive) 1254 del vars, 8720 del conss, 2585 add conss, 70 chg bounds, 0 chg sides, 10 chg coeffs, 7472 upgd conss, 126 impls, 13370 clqs
(round 19, fast)       1254 del vars, 8724 del conss, 2585 add conss, 70 chg bounds, 0 chg sides, 10 chg coeffs, 7472 upgd conss, 126 impls, 13370 clqs
(round 20, exhaustive) 1279 del vars, 8724 del conss, 2585 add conss, 70 chg bounds, 0 chg sides, 10 chg coeffs, 7472 upgd conss, 152 impls, 13835 clqs
(round 21, fast)       1279 del vars, 8754 del conss, 2585 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7472 upgd conss, 152 impls, 13835 clqs
(round 22, exhaustive) 1736 del vars, 9212 del conss, 2586 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7472 upgd conss, 152 impls, 9142 clqs
(round 23, exhaustive) 1761 del vars, 9212 del conss, 2586 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7472 upgd conss, 305 impls, 19227 clqs
(round 24, fast)       1761 del vars, 9221 del conss, 2586 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7479 upgd conss, 305 impls, 19227 clqs
(round 25, exhaustive) 1844 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7479 upgd conss, 315 impls, 17488 clqs
(round 26, exhaustive) 1869 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7479 upgd conss, 408 impls, 17248 clqs
(round 27, fast)       1869 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7484 upgd conss, 408 impls, 17248 clqs
(round 28, exhaustive) 1894 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7484 upgd conss, 587 impls, 19540 clqs
(round 29, fast)       1894 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7506 upgd conss, 587 impls, 19540 clqs
(round 30, exhaustive) 1919 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7506 upgd conss, 696 impls, 19393 clqs
(round 31, fast)       1919 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7529 upgd conss, 696 impls, 19393 clqs
   (1.0s) probing: 1000/2640 (37.9%) - 69 fixings, 195 aggregations, 314298 implications, 2 bound changes
   (1.0s) probing: 2000/2640 (75.8%) - 74 fixings, 195 aggregations, 344098 implications, 2 bound changes
   (1.0s) probing cycle finished: starting next cycle
(round 32, exhaustive) 1945 del vars, 9310 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7529 upgd conss, 851 impls, 19220 clqs
(round 33, fast)       1945 del vars, 9318 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7549 upgd conss, 851 impls, 19220 clqs
(round 34, fast)       1945 del vars, 9323 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7549 upgd conss, 851 impls, 19235 clqs
(round 35, exhaustive) 1986 del vars, 9377 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7549 upgd conss, 851 impls, 17702 clqs
(round 36, exhaustive) 2011 del vars, 9377 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7549 upgd conss, 851 impls, 17518 clqs
(round 37, fast)       2011 del vars, 9398 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7557 upgd conss, 851 impls, 17518 clqs
(round 38, fast)       2011 del vars, 9403 del conss, 2589 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7557 upgd conss, 851 impls, 17518 clqs
(round 39, exhaustive) 2076 del vars, 9499 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7557 upgd conss, 851 impls, 15198 clqs
(round 40, fast)       2076 del vars, 9503 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7557 upgd conss, 851 impls, 15198 clqs
(round 41, exhaustive) 2101 del vars, 9503 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7557 upgd conss, 851 impls, 18261 clqs
(round 42, fast)       2101 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7572 upgd conss, 851 impls, 18261 clqs
(round 43, exhaustive) 2126 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7572 upgd conss, 851 impls, 17976 clqs
(round 44, fast)       2126 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7590 upgd conss, 851 impls, 17976 clqs
(round 45, exhaustive) 2151 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7590 upgd conss, 851 impls, 18723 clqs
(round 46, fast)       2151 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7614 upgd conss, 851 impls, 18723 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 47, exhaustive) 2176 del vars, 9518 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 11 chg coeffs, 7614 upgd conss, 851 impls, 18376 clqs
(round 48, fast)       2176 del vars, 9535 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7630 upgd conss, 851 impls, 18376 clqs
(round 49, fast)       2176 del vars, 9550 del conss, 2600 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7630 upgd conss, 851 impls, 18378 clqs
(round 50, exhaustive) 2201 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7630 upgd conss, 851 impls, 17177 clqs
(round 51, exhaustive) 2226 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7630 upgd conss, 851 impls, 17627 clqs
(round 52, fast)       2226 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7641 upgd conss, 851 impls, 17627 clqs
(round 53, exhaustive) 2251 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7641 upgd conss, 851 impls, 18007 clqs
(round 54, fast)       2251 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7654 upgd conss, 851 impls, 18007 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 55, exhaustive) 2276 del vars, 9594 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7654 upgd conss, 851 impls, 18145 clqs
(round 56, fast)       2276 del vars, 9599 del conss, 2602 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7662 upgd conss, 851 impls, 18145 clqs
(round 57, exhaustive) 2276 del vars, 9638 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7662 upgd conss, 851 impls, 18153 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 58, exhaustive) 2301 del vars, 9638 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 12 chg coeffs, 7662 upgd conss, 851 impls, 17448 clqs
(round 59, fast)       2301 del vars, 9659 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7674 upgd conss, 851 impls, 17450 clqs
(round 60, fast)       2301 del vars, 9664 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7674 upgd conss, 851 impls, 17457 clqs
(round 61, exhaustive) 2308 del vars, 9677 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7674 upgd conss, 851 impls, 16925 clqs
   (1.0s) probing cycle finished: starting next cycle
(round 62, exhaustive) 2327 del vars, 9677 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7674 upgd conss, 851 impls, 16232 clqs
(round 63, fast)       2327 del vars, 9684 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7675 upgd conss, 851 impls, 16232 clqs
(round 64, exhaustive) 2327 del vars, 9704 del conss, 2603 add conss, 70 chg bounds, 0 chg sides, 13 chg coeffs, 7675 upgd conss, 851 impls, 16232 clqs
   (1.0s) probing: 248/347 (71.5%) - 203 fixings, 317 aggregations, 407699 implications, 2 bound changes
   (1.0s) probing aborted: 50/50 successive totally useless probings
   Deactivated symmetry handling methods, since SCIP was built without symmetry detector (SYM=none).
presolving (65 rounds: 65 fast, 37 medium, 37 exhaustive):
 2327 deleted vars, 9704 deleted constraints, 2603 added constraints, 70 tightened bounds, 0 added holes, 0 changed sides, 13 changed coefficients
 851 implications, 16326 cliques
presolved problem has 346 variables (345 bin, 0 int, 0 impl, 1 cont) and 441 constraints
    122 constraints of type <setppc>
    281 constraints of type <and>
     38 constraints of type <linear>
Presolving Time: 1.00
transformed 1/1 original solutions to the transformed problem space

 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
p 1.0s|     1 |     0 |     0 |     - |  clique|   0 | 346 | 441 | 722 |   0 |  0 |   0 |   0 | 2.341078e+02 | 5.325838e+01 | 339.57%| unknown
p 1.0s|     1 |     0 |     0 |     - | vbounds|   0 | 346 | 450 | 722 |   0 |  0 |   9 |   0 | 2.341078e+02 | 5.500000e+01 | 325.65%| unknown
  1.0s|     1 |     0 |   248 |     - |    29M |   0 | 346 | 466 | 722 |   0 |  0 |  25 |   0 | 5.667140e+01 | 5.500000e+01 |   3.04%| unknown
  1.0s|     1 |     0 |   248 |     - |    29M |   0 | 346 | 477 | 722 |   0 |  0 |  36 |   0 | 5.667140e+01 | 5.500000e+01 |   3.04%| unknown
  1.0s|     1 |     0 |   248 |     - |    29M |   0 | 346 | 477 | 719 |   0 |  0 |  36 |   0 | 5.667140e+01 | 5.500000e+01 |   3.04%| unknown
  1.0s|     1 |     0 |   463 |     - |    29M |   0 | 346 | 477 | 751 |  32 |  1 |  36 |   0 | 5.667140e+01 | 5.500000e+01 |   3.04%| unknown
  1.0s|     1 |     0 |  1090 |     - |    30M |   0 | 346 | 477 | 775 |  56 |  2 |  36 |   0 | 5.647661e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1090 |     - |    30M |   0 | 346 | 479 | 775 |  56 |  2 |  38 |   0 | 5.647661e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1328 |     - |    30M |   0 | 346 | 479 | 806 |  87 |  3 |  38 |   0 | 5.647661e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1543 |     - |    30M |   0 | 346 | 480 | 828 | 109 |  4 |  39 |   0 | 5.647661e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1543 |     - |    30M |   0 | 346 | 481 | 818 | 109 |  4 |  40 |   0 | 5.647661e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1742 |     - |    30M |   0 | 346 | 477 | 842 | 133 |  5 |  40 |   0 | 5.647556e+01 | 5.500000e+01 |   2.68%| unknown
  1.0s|     1 |     0 |  1878 |     - |    31M |   0 | 346 | 477 | 866 | 157 |  6 |  40 |   0 | 5.647556e+01 | 5.500000e+01 |   2.68%| unknown
  2.0s|     1 |     0 |  2046 |     - |    32M |   0 | 346 | 482 | 893 | 184 |  7 |  45 |   0 | 5.647556e+01 | 5.500000e+01 |   2.68%| unknown
  2.0s|     1 |     0 |  2333 |     - |    33M |   0 | 346 | 482 | 914 | 205 |  8 |  45 |   0 | 5.647185e+01 | 5.500000e+01 |   2.68%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  2.0s|     1 |     0 |  2458 |     - |    34M |   0 | 346 | 482 | 935 | 226 |  9 |  45 |   0 | 5.646843e+01 | 5.500000e+01 |   2.67%| unknown
  2.0s|     1 |     0 |  2712 |     - |    36M |   0 | 346 | 482 | 944 | 235 | 10 |  45 |   0 | 5.646731e+01 | 5.500000e+01 |   2.67%| unknown
  2.0s|     1 |     0 |  3009 |     - |    36M |   0 | 346 | 486 | 940 | 244 | 11 |  49 |   0 | 5.629125e+01 | 5.500000e+01 |   2.35%| unknown
  2.0s|     1 |     0 |  3009 |     - |    36M |   0 | 346 | 486 | 940 | 244 | 11 |  49 |   0 | 5.629125e+01 | 5.500000e+01 |   2.35%| unknown
  2.0s|     1 |     0 |  3156 |     - |    36M |   0 | 346 | 486 | 957 | 261 | 12 |  49 |   0 | 5.628892e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  3247 |     - |    36M |   0 | 346 | 489 | 974 | 278 | 13 |  52 |   0 | 5.628705e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  3331 |     - |    36M |   0 | 346 | 489 | 982 | 286 | 14 |  52 |   0 | 5.628705e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  3654 |     - |    36M |   0 | 346 | 492 | 987 | 291 | 15 |  55 |   0 | 5.628705e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  3848 |     - |    36M |   0 | 346 | 492 |1004 | 308 | 16 |  55 |   0 | 5.628705e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  3959 |     - |    36M |   0 | 346 | 492 | 997 | 320 | 17 |  55 |   0 | 5.628705e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  4600 |     - |    37M |   0 | 346 | 493 |1005 | 328 | 18 |  56 |   0 | 5.628585e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  5245 |     - |    37M |   0 | 346 | 493 |1022 | 345 | 19 |  56 |   0 | 5.628499e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  5900 |     - |    37M |   0 | 346 | 493 |1035 | 358 | 20 |  56 |   0 | 5.628444e+01 | 5.500000e+01 |   2.34%| unknown
  2.0s|     1 |     0 |  6259 |     - |    37M |   0 | 346 | 500 |1049 | 372 | 21 |  63 |   0 | 5.628243e+01 | 5.500000e+01 |   2.33%| unknown
  2.0s|     1 |     0 |  6728 |     - |    37M |   0 | 346 | 500 |1061 | 384 | 22 |  63 |   0 | 5.628105e+01 | 5.500000e+01 |   2.33%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  2.0s|     1 |     0 |  6728 |     - |    37M |   0 | 346 | 500 |1074 | 384 | 22 |  63 |   0 | 5.628105e+01 | 5.500000e+01 |   2.33%| unknown
  2.0s|     1 |     0 |  7070 |     - |    37M |   0 | 346 | 500 |1045 | 392 | 23 |  63 |   0 | 5.624212e+01 | 5.500000e+01 |   2.26%| unknown
  2.0s|     1 |     0 |  7593 |     - |    37M |   0 | 346 | 500 |1058 | 405 | 24 |  63 |   0 | 5.624212e+01 | 5.500000e+01 |   2.26%| unknown
  2.0s|     1 |     0 |  7658 |     - |    37M |   0 | 346 | 500 |1072 | 419 | 25 |  63 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  7658 |     - |    37M |   0 | 346 | 505 |1072 | 419 | 25 |  68 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  7689 |     - |    37M |   0 | 346 | 505 |1083 | 430 | 26 |  68 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8196 |     - |    37M |   0 | 346 | 505 |1090 | 437 | 27 |  68 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8494 |     - |    37M |   0 | 346 | 506 |1102 | 449 | 28 |  69 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8641 |     - |    37M |   0 | 346 | 508 |1085 | 462 | 29 |  71 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8742 |     - |    37M |   0 | 346 | 513 |1092 | 469 | 30 |  76 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8812 |     - |    37M |   0 | 346 | 513 |1097 | 474 | 31 |  76 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  8941 |     - |    37M |   0 | 346 | 513 |1102 | 479 | 32 |  76 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  9022 |     - |    37M |   0 | 346 | 515 |1109 | 486 | 33 |  78 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  9140 |     - |    37M |   0 | 346 | 519 |1114 | 491 | 34 |  82 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
  2.0s|     1 |     0 |  9176 |     - |    37M |   0 | 346 | 520 |1054 | 500 | 35 |  83 |   0 | 5.619458e+01 | 5.500000e+01 |   2.17%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  2.0s|     1 |     2 | 10381 |     - |    38M |   0 | 346 | 520 |1054 | 500 | 35 |  83 |  22 | 5.618295e+01 | 5.500000e+01 |   2.15%| unknown
(run 1, node 1) restarting after 13 global fixings of integer variables

(restart) converted 151 cuts from the global cut pool into linear constraints

presolving:
(round 1, fast)       13 del vars, 1 del conss, 0 add conss, 0 chg bounds, 14 chg sides, 20 chg coeffs, 0 upgd conss, 851 impls, 14448 clqs
(round 2, exhaustive) 13 del vars, 3 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 20 chg coeffs, 0 upgd conss, 851 impls, 14448 clqs
(round 3, exhaustive) 13 del vars, 3 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 20 chg coeffs, 137 upgd conss, 851 impls, 14448 clqs
(round 4, exhaustive) 13 del vars, 5 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 20 chg coeffs, 137 upgd conss, 851 impls, 14448 clqs
(round 5, exhaustive) 13 del vars, 5 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 23 chg coeffs, 137 upgd conss, 851 impls, 14448 clqs
(round 6, exhaustive) 13 del vars, 17 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 24 chg coeffs, 137 upgd conss, 851 impls, 14448 clqs
(round 7, exhaustive) 13 del vars, 22 del conss, 0 add conss, 0 chg bounds, 16 chg sides, 25 chg coeffs, 137 upgd conss, 851 impls, 14448 clqs
presolving (8 rounds: 8 fast, 7 medium, 7 exhaustive):
 13 deleted vars, 22 deleted constraints, 0 added constraints, 0 tightened bounds, 0 added holes, 16 changed sides, 26 changed coefficients
 851 implications, 14448 cliques
presolved problem has 333 variables (332 bin, 0 int, 0 impl, 1 cont) and 649 constraints
      2 constraints of type <varbound>
     11 constraints of type <knapsack>
    257 constraints of type <setppc>
    268 constraints of type <and>
     50 constraints of type <linear>
     61 constraints of type <logicor>
Presolving Time: 2.00
transformed 1/3 original solutions to the transformed problem space

 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  3.0s|     1 |     0 | 10633 |     - |    37M |   0 | 333 | 649 | 844 |   0 |  0 |  83 |  22 | 5.618295e+01 | 5.500000e+01 |   2.15%| unknown
  3.0s|     1 |     0 | 10813 |     - |    37M |   0 | 333 | 649 | 869 |  25 |  1 |  83 |  22 | 5.618295e+01 | 5.500000e+01 |   2.15%| unknown
  3.0s|     1 |     0 | 11161 |     - |    37M |   0 | 333 | 653 | 885 |  41 |  2 |  87 |  22 | 5.618295e+01 | 5.500000e+01 |   2.15%| unknown
  3.0s|     1 |     0 | 11525 |     - |    37M |   0 | 333 | 656 | 909 |  65 |  3 |  90 |  22 | 5.618295e+01 | 5.500000e+01 |   2.15%| unknown
  3.0s|     1 |     0 | 11896 |     - |    37M |   0 | 333 | 656 | 931 |  87 |  4 |  90 |  22 | 5.618070e+01 | 5.500000e+01 |   2.15%| unknown
  3.0s|     1 |     0 | 12129 |     - |    37M |   0 | 333 | 656 | 941 |  97 |  5 |  90 |  22 | 5.617682e+01 | 5.500000e+01 |   2.14%| unknown
  3.0s|     1 |     0 | 12230 |     - |    39M |   0 | 333 | 660 | 955 | 111 |  6 |  94 |  22 | 5.617480e+01 | 5.500000e+01 |   2.14%| unknown
  3.0s|     1 |     0 | 12621 |     - |    41M |   0 | 333 | 662 | 964 | 120 |  7 |  96 |  22 | 5.617480e+01 | 5.500000e+01 |   2.14%| unknown
  3.0s|     1 |     0 | 13029 |     - |    41M |   0 | 333 | 662 | 984 | 140 |  8 |  96 |  22 | 5.617480e+01 | 5.500000e+01 |   2.14%| unknown
  3.0s|     1 |     0 | 13434 |     - |    41M |   0 | 333 | 662 | 994 | 150 |  9 |  96 |  22 | 5.617317e+01 | 5.500000e+01 |   2.13%| unknown
  3.0s|     1 |     0 | 13817 |     - |    43M |   0 | 333 | 663 |1001 | 157 | 10 |  97 |  22 | 5.617287e+01 | 5.500000e+01 |   2.13%| unknown
  3.0s|     1 |     0 | 13852 |     - |    43M |   0 | 333 | 667 |1013 | 169 | 11 | 101 |  22 | 5.616946e+01 | 5.500000e+01 |   2.13%| unknown
  3.0s|     1 |     0 | 13907 |     - |    43M |   0 | 333 | 667 |1023 | 179 | 12 | 101 |  22 | 5.615575e+01 | 5.500000e+01 |   2.10%| unknown
  3.0s|     1 |     0 | 14043 |     - |    43M |   0 | 333 | 669 |1035 | 191 | 13 | 103 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
  3.0s|     1 |     0 | 14043 |     - |    43M |   0 | 333 | 669 |1035 | 191 | 13 | 103 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
 time | node  | left  |LP iter|LP it/n|mem/heur|mdpt |vars |cons |rows |cuts |sepa|confs|strbr|  dualbound   | primalbound  |  gap   | compl.
  3.0s|     1 |     0 | 14175 |     - |    43M |   0 | 333 | 669 | 972 | 208 | 14 | 103 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
  3.0s|     1 |     0 | 14362 |     - |    43M |   0 | 333 | 672 | 986 | 222 | 15 | 106 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
  3.0s|     1 |     0 | 14448 |     - |    43M |   0 | 333 | 672 | 992 | 228 | 16 | 106 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
  3.0s|     1 |     0 | 14601 |     - |    43M |   0 | 333 | 672 | 999 | 235 | 17 | 106 |  22 | 5.612656e+01 | 5.500000e+01 |   2.05%| unknown
  3.0s|     1 |     0 | 14799 |     - |    43M |   0 | 333 | 677 |1006 | 242 | 18 | 111 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  3.0s|     1 |     0 | 15047 |     - |    43M |   0 | 333 | 677 |1016 | 252 | 19 | 111 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  3.0s|     1 |     0 | 15440 |     - |    44M |   0 | 333 | 677 | 979 | 260 | 20 | 111 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  3.0s|     1 |     0 | 15463 |     - |    44M |   0 | 333 | 677 | 987 | 268 | 21 | 111 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  3.0s|     1 |     0 | 15916 |     - |    44M |   0 | 333 | 677 | 992 | 273 | 22 | 111 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  3.0s|     1 |     0 | 15969 |     - |    44M |   0 | 333 | 678 | 999 | 280 | 23 | 112 |  22 | 5.612198e+01 | 5.500000e+01 |   2.04%| unknown
  4.0s|     1 |     2 | 16608 |     - |    44M |   0 | 333 | 686 | 999 | 280 | 23 | 120 |  44 | 5.610614e+01 | 5.500000e+01 |   2.01%| unknown
d 4.0s|     6 |     7 | 17620 | 476.0 |pscostdi|   4 | 333 | 686 | 938 |   0 |  2 | 120 |  44 | 5.610614e+01 | 5.600000e+01 |   0.19%| unknown

SCIP Status        : solving was interrupted [gap limit reached]
Solving Time (sec) : 4.00
Solving Nodes      : 6 (total of 7 nodes in 2 runs)
Primal Bound       : +5.60000000000000e+01 (4 solutions)
Dual Bound         : +5.61061360410820e+01
Gap                : 0.19 %
```

## Solution

### Phase One

```text
TABLE 1 (222)
	Henry (55)
	Evelyn (56)
	Alexander (56)
	Harper (55)

TABLE 2 (232)
	Mason (60)
	Camila (56)
	Michael (56)
	Gianna (60)

TABLE 3 (370.07539111999995)
	Liam (65)
	Olivia (61)
	Noah (59.03769556)
	Emma (66)
	Oliver (66)
	Ava (53.03769556)

TABLE 4 (708.353517492)
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

TABLE 5 (696.762801268)
	Sam (66.499694416)
	Frances (109.88170621799999)
	Oliver (150)
	Anastasia (86)
	Alan (66.09916386)
	Heza (71)
	David (71)
	Katrina (76.282236774)

Solution Value: 2229.19170988
```

## Phase Two

```text
TABLE 1 (232)
	Liam (60)
	Olivia (56)
	Noah (56)
	Emma (60)

TABLE 2 (232)
	Mason (60)
	Camila (56)
	Michael (56)
	Gianna (60)

TABLE 3 (468.873769238)
	Oliver (58.916873472)
	Ava (59.343252401)
	Elijah (56.176758746)
	Charlotte (60)
	Benjamin (60.415724894)
	Isabella (58.021159725)
	Lucas (56)
	Mia (60)

TABLE 4 (465.03783784000007)
	William (58.578439369)
	Sophia (56)
	James (57.940479551)
	Amelia (60)
	Alan (60)
	Heza (56)
	David (57.940479551)
	Katrina (58.578439369)

TABLE 5 (601.944276858)
	Henry (59.184061146)
	Evelyn (56)
	Alexander (59.247505058)
	Harper (57.540572225)
	Sam (76.72463337100001)
	Frances (110)
	Oliver (113.247505058)
	Anastasia (70)

Solution Value: 1999.855883936
```

## Observations

Observe that the total pairing reward in the first phase was 2229.19, and the total pairing reward in the second phase was 1999.86 (89.7%, with an 80% tolerance).

The minimum pairing reward in the first phase was for Ava, with a reward of 53.0377. The minimum pairing reward for the second phase was 56, and was shared for Olivia, Noah, Camila, Michael, Lucas, Sophia, Heza, and Evelyn. The minimum pairing reward was improved by 5.6%.
