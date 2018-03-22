using System;
using System.Collections.Generic;
using System.Linq;
namespace CrackingTheCode6th.Chapter1 {
    public class Q1_2 : Quiz {
        IList<string[]> args = new List<string[]> ();

        public override void Test () {
            args.Add (new string[] { "abcz", "bcaf" });
            args.Add (new string[] { "ffdsa", "asdff" });
            args.Add (new string[] { "boidsss", "ssboid" });
            args.Add (new string[] { "aaab", "ab" });

            foreach (string[] arg in args) {
                System.Console.WriteLine (arg[0] + " and " + arg[1] + " is Permutation? " + IsPermutation (arg));
                System.Console.WriteLine (arg[0] + " and " + arg[1] + " is Permutation? " + IsPermutationEfficiency (arg));

            }

        }

        private bool IsPermutationEfficiency (string[] arg) {
            if (arg[0].Length != arg[1].Length) {
                return false;
            }

            int[] hash = new int[128];
            for (int i = 0; i < arg[0].Length; i++) {
                hash[(int) arg[0][i]]++;
            }
            for (int i = 0; i < arg[0].Length; i++) {
                hash[(int) arg[1][i]]--;
                if(hash[(int) arg[1][i]]<0){
                    return false;
                }
            }

            return true;
        }

        private bool IsPermutation (string[] arg) {
            if (arg[0].Length != arg[1].Length) {
                return false;
            }
            string a = new string (arg[0].OrderBy (o => o).ToArray ());
            string b = new string (arg[1].OrderBy (o => o).ToArray ());

            if (a == b) {
                return true;
            } else {
                return false;
            }
        }
    }
}