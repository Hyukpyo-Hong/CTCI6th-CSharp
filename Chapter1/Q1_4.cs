using System;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_4 : Quiz {
        public override void Test () {
            IsParlindromePermutation ("Tact Coa");
        }

        private void IsParlindromePermutation (string s) {
            int a = (int)
            'a';
            int z = (int)
            'z';

            int charNum;
            int[] asciiHash = new int[128];
            s = s.ToLower();            
            foreach (char character in s) {
                charNum = (int) character;
                if ((charNum >= a && charNum <= z)) {
                    asciiHash[charNum]++;                    
                }
            }
            int odd = 0;
            foreach (int val in asciiHash) {                
                if (val % 2 != 0) {                    
                    odd++;
                }
            }
            System.Console.WriteLine(odd<2);
        }
    }
}