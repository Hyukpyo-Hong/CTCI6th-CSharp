using System;

namespace CrackingTheCode6th.PracticeForRef {
    public class Fibonacci : Quiz {
        public override void Test () {
            System.Console.WriteLine ("Answer");
            System.Console.WriteLine ("1 1 2 3 5 8 13 21 34 55 89");
            System.Console.WriteLine ("Recursive O(2^n)");
            for (int i = 1; i < 12; i++) {
                System.Console.Write (NthFibonacciNumberRecursive (i) + " ");
            }
            System.Console.WriteLine ();

            System.Console.WriteLine ("Top Down O(n)");
            for (int i = 1; i < 12; i++) {
                System.Console.Write (NthFibonacciNumberTopDown (i, new int[i + 1]) + " ");
            }
            System.Console.WriteLine ();

            System.Console.WriteLine ("Bottom Up");
            for (int i = 1; i < 12; i++) {
                System.Console.Write (NthFibonacciNumberBottomUp (i) + " ");
            }
            System.Console.WriteLine ();

            System.Console.WriteLine ("Bottom Up");
            for (int i = 1; i < 12; i++) {
                System.Console.Write (NthFibonacciNumberBottomUpSpaceMinimize (i) + " ");
            }
            System.Console.WriteLine ();

        }

        private int NthFibonacciNumberBottomUpSpaceMinimize (int i) {
            if (i == 0 || i == 1) return i;
            int a = 0;
            int b = 1;
            int c=0;
            for (int k = 2; k < i + 1; k++) {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        private int NthFibonacciNumberBottomUp (int i) {
            if (i == 0 || i == 1) return i;
            int[] memo = new int[i + 1];
            memo[0] = 0;
            memo[1] = 1;
            for (int k = 2; k < i + 1; k++) {
                memo[k] = memo[k - 1] + memo[k - 2];
            }
            return memo[i - 1] + memo[i - 2];
        }

        private int NthFibonacciNumberTopDown (int i, int[] memo) {
            if (i == 0 || i == 1) return i;

            if (memo[i] == 0) {
                memo[i] = NthFibonacciNumberTopDown (i - 1, memo) + NthFibonacciNumberTopDown (i - 2, memo);
            }
            return memo[i];

        }

        private int NthFibonacciNumberRecursive (int n) {
            if (n == 0 || n == 1) return n;
            return NthFibonacciNumberRecursive (n - 1) + NthFibonacciNumberRecursive (n - 2);

        }
    }
}