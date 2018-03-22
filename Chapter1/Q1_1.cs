using System.Collections.Generic;
using CrackingTheCode6th;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_1 : Quiz {
        string[] args = new string[] { "abcdef", "aabbcc", "abcdeef" };

        public override void Test () {
            List<char> temp;
            bool flag;
            foreach (string val in args) {
                temp = new List<char> ();
                flag = true;
                foreach (char c in val) {
                    if (temp.Contains (c)) {
                        flag = false;
                        break;
                    } else {
                        temp.Add (c);
                    }
                }
                if (flag) {
                    System.Console.WriteLine (val + " is unique");
                } else {
                    System.Console.WriteLine (val + " is not unique");
                }
            }
        }
    }
}