using System;

namespace CrackingTheCode6th.Chapter1 {
    public class Q1_9 : Quiz {
        public override void Test () {
            IsRoation ("waterbottle", "erbottlewat");
            IsRoation ("waterbottlea", "erbottlewat");
            IsRoation ("waterbottle", "arbottlewat");
        }

        private void IsRoation (string v1, string v2) {
            bool result = true;
            if (v1.Length == v2.Length) {
                int startIdx = v2.IndexOf (v1[0]);
                int counter=0;
                for (int i = startIdx; i < v2.Length; i++) {
                    if (v1[counter++] != v2[i]) {
                        result = false;
                        break;
                    }
                }
                for (int i = 0; i < startIdx; i++) {
                    if (v1[counter++] != v2[i]) {
                        result = false;
                        break;
                    }
                }
            } else {
                result = false;
            }

            if (result) {
                System.Console.WriteLine (v1 + " is roation of " + v2);
            } else {
                System.Console.WriteLine (v1 + " is NOT roation of " + v2);
            }
        }
    }
}