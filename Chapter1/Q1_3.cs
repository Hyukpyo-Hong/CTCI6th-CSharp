using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_3 : Quiz {

        public override void Test () {
            ReplaceSpace ("Mr John Smith   ", 13);

        }

        private void ReplaceSpace (string v1, int v2) {
            StringBuilder sb = new StringBuilder ();
            for (int i = 0; i < v2; i++) {                
                if (v1[i] ==' ') {
                    sb.Append ("%20");
                } else {
                    sb.Append (v1[i]);
                }
            }
            System.Console.WriteLine(sb.ToString());
        }
    }

}