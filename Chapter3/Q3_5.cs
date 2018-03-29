using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_5 : Quiz {
        public override void Test () {
            Stack<int> stack = new Stack<int> ();
            Random rnd = new Random();
            int random;
            for (int i = 0; i < 10; i++) {
                random = rnd.Next(1,10);
                stack.Push (random);
                System.Console.Write (random + " ");
            }
            System.Console.WriteLine ();

            SortStack (stack);
        }

        private void SortStack (Stack<int> stack) {
            Stack<int> tempStack = new Stack<int> ();
            int temp;
            while (stack.Count != 0) {
                temp = stack.Pop ();
                if (tempStack.Count != 0) {
                    while (tempStack.Count != 0 && tempStack.Peek () > temp) {
                        stack.Push (tempStack.Pop ());
                    }
                }
                tempStack.Push (temp);
            }

            while (tempStack.Count != 0) {
                System.Console.Write(tempStack.Peek()+" ");
                stack.Push (tempStack.Pop ());
            }
            System.Console.WriteLine();
        }
    }
}