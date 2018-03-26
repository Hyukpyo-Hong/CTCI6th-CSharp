using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_6 : Quiz {
        public override void Test () {
            LinkedList<int> list = new LinkedList<int> ();
            list.AddLast (0);
            list.AddLast (1);
            list.AddLast (2);
            list.AddLast (1);
            list.AddLast (0);
            IsPalindrome (list);
        }

        private void IsPalindrome (LinkedList<int> list) {
            Stack<int> stack = new Stack<int> ();
            Queue<int> queue = new Queue<int> ();
            int count = 0;
            foreach (var item in list) {
                stack.Push (item);
                queue.Enqueue (item);
                count++;
            }
            bool result = true;
            for (int i = 0; i < count; i++) {
                if (stack.Pop () != queue.Dequeue ()) {
                    result = false;
                    break;
                }
            }

            if (result) {
                System.Console.WriteLine ("Pelindome");
            } else {
                System.Console.WriteLine ("Not Pelindome");
            }

        }
    }
}