using System;
using System.Text;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_6 : Quiz {

        public override void Test () {
            StringCompression ("aabcccccaaa");
            StringCompression ("abcdefghij");
        }

        private void StringCompression (string v) {                    
            char guide = ' ';
            int count = 0;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < v.Length; i++) {
                if (guide != v[i]) {                    
                    if (i != 0) {
                        result.Append(count.ToString ());
                    }
                    guide = v[i];
                    result.Append(v[i]);
                    count = 1;
                } else {
                    count++;
                }
            }
            result.Append(count.ToString ());
            if (v.Length <= result.Length) {
                System.Console.WriteLine (v);
            } else {
                System.Console.WriteLine (result.ToString());
            }

        }
    }
}