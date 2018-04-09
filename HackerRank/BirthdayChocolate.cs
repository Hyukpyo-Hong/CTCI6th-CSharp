using System.Collections;
using System.Collections.Generic;

namespace CrackingTheCode6th.HackerRank {
    public class BirthdayChocolate : Quiz {
        public override void Test () {
            //System.Console.WriteLine ("2: " + solve (5, new int[] { 1, 2, 1, 3, 2 }, 3, 2));

        }
        static int solve (int n, int[] s, int d, int m) {

            List<int> list = new List<int> (s);

            foreach (int num in list) {
                list.Remove (1);
            }

            return 0;
        }
    }
}