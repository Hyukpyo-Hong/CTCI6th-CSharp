using System;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_7 : Quiz {
        public override void Test () {

            int n = 4;
            int[, ] matrix = new int[n, n];
            int val = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    matrix[i, j] = val++;
                }
            }

            ShowMatrix (matrix);
            matrix = Rotate (matrix);
            ShowMatrix (matrix);

        }

        private int[, ] Rotate (int[, ] matrix) {
            int n = matrix.GetLength(0);
            int[, ] temp = new int[n, n ];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    temp[j, n - (i+1)] = matrix[i, j];
                }
            }
                System.Console.WriteLine ("---Rotate--");
           
            return temp;
        }

        private void ShowMatrix (int[,] matrix) {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    System.Console.Write (matrix[i,j] + " ");
                }
                System.Console.WriteLine ();
            }
        }
    }
}