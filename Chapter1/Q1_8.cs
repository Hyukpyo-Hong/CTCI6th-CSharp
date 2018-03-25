using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_8 : Quiz {
        public override void Test () {
            int m = 5;
            int n = 2;
            int[, ] matrix = new int[m, n];
            
            Random rnd = new Random ();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    matrix[i, j] = rnd.Next (0, 10);
                }
            }

            ShowMatrix (matrix);
            ZeroMatrix (matrix);
            ShowMatrix (matrix);
        }

        private void ZeroMatrix (int[, ] matrix) {
            int m = matrix.GetLength (0);
            int n = matrix.GetLength (1);
            HashSet<int> rows = new HashSet<int> ();
            HashSet<int> columns = new HashSet<int> ();

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (!columns.Contains (j)) {
                        if (matrix[i, j] == 0) {
                            rows.Add (i);
                            columns.Add (j);                            
                        }
                    }
                }
            }

            foreach (var row in rows) {
                for (int i = 0; i < n; i++) {
                    matrix[row, i] = 0;
                }
            }
            foreach (var column in columns) {
                for (int i = 0; i < m; i++) {
                    matrix[i, column] = 0;
                }
            }
            System.Console.WriteLine("Compute--------------");
        }

        private void ShowMatrix (int[, ] matrix) {
            int m = matrix.GetLength (0);
            int n = matrix.GetLength (1);
            
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    System.Console.Write (matrix[i, j] + " ");
                }
                System.Console.WriteLine ();
            }
        }
    }
}