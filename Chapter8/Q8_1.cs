using System;

namespace CrackingTheCode6th.Chapter8 {
    public class Q8_1 : Quiz {
        public override void Test () {

            int n = 1;
            int[] memo = new int[n + 1];
            InitialArray (memo);
            System.Console.WriteLine (CountPossible (n, memo));

            n = 3;
            memo = new int[n + 1];
            InitialArray (memo);
            System.Console.WriteLine (CountPossible (n, memo));

            n = 4;
            memo = new int[n + 1];
            InitialArray (memo);
            System.Console.WriteLine (CountPossible (n, memo));

        }

        private void InitialArray (int[] memo) {
            for (int i = 0; i < memo.Length ; i++) {
                memo[i] = -1;
            }
        }

        private int CountPossible (int current, int[] memo) {
            if (current == 0) {
                return 1;
            } else if (current < 0) {
                return 0;
            } else if (memo[current] != -1) {
                return memo[current];
            } else {
                memo[current] = CountPossible (current - 1, memo) + CountPossible (current - 2, memo) + CountPossible (current - 3, memo);
                return memo[current];
            }

        }

    }
}