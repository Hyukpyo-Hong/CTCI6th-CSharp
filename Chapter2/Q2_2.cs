using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_2 : Quiz {
        public override void Test () {
            LinkedList<char> list = new LinkedList<char> ();
            Random rnd = new Random ();
            for (int i = 0; i < 100; i++) {
                list.AddLast ((char) rnd.Next ((int)
                    'a', (int)
                    'z'));
            }
            ShowList (list);
            int k = 3;
            KthTotheLast (list, k);

        }

        private void KthTotheLast (LinkedList<char> list, int k) {            
            Stack<char> stack = new Stack<char> ();
            foreach (var item in list) {
                stack.Push (item);
            }
            for (int i = 0; i < k-1; i++)
            {
                stack.Pop();
            }
            System.Console.WriteLine(k+"th Element is "+stack.Pop());
        }

        private void ShowList (LinkedList<char> list) {
            foreach (var item in list) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine ();
        }
    }
}