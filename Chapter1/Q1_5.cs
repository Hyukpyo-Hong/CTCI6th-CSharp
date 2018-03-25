using System;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_5 : Quiz {
        public override void Test () {
            IsOneAway ("pale", "ple");
            IsOneAway ("pal", "pale");
            IsOneAway ("pales", "pale");
            IsOneAway ("pale", "bale");
            IsOneAway ("pale", "bae");
            IsOneAway ("ple", "baea");
            IsOneAway ("ple", "pleple");
            
        }

        private void IsOneAway (string s1, string s2) {
            bool result = true;
            if (Math.Abs (s1.Length - s2.Length) > 1) {
                result = false;
            } else {
                int[] hash = new int[128];
                for (int i = 0; i < s1.Length; i++) {
                    hash[(int) s1[i]]++;
                }
                for (int i = 0; i < s2.Length; i++) {
                    hash[(int) s2[i]]--;
                }
                int plusOne = 0;
                int minusOne = 0;
                foreach (var item in hash) {
                    if (item != 0) {
                        if (item == 1) plusOne++;
                        else if (item == -1) minusOne++;
                        else {
                            result = false;
                            break;
                        }
                    }
                }
                if (plusOne > 1 || minusOne > 1) result = false;
            }
            System.Console.WriteLine (s1 + " : " + s2 + " " + result);
        }
    }
}