using System;
using System.Collections;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_3 : Quiz {
        public override void Test () {
            SetOfStack setOfStack = new SetOfStack ();
            for (int i = 0; i < 10; i++) {
                setOfStack.Push (i);
                System.Console.Write (i + " ");
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ("Number Of Set: " + setOfStack.list.Count);
            for (int i = 0; i < 10; i++) {
                System.Console.WriteLine ("Pop: " + setOfStack.Pop ());
            }
            System.Console.WriteLine ("Number Of Set: " + setOfStack.list.Count);

            //Pop At
            for (int i = 0; i < 10; i++) {
                setOfStack.Push (i);
                System.Console.Write (i + " ");
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ("Pop at 3: "+setOfStack.PopAt (3));

        }
    }

    internal class SetOfStack {
        int threshold = 3;
        int setNumber = 0;
        int counter = 0;
        public List<Stack<int>> list = new List<Stack<int>> ();

        public void Push (int i) {
            if (counter == 0) {
                Stack<int> stack = new Stack<int> ();
                stack.Push (i);
                list.Add (stack);
                counter++;
            } else if (counter == threshold) {
                setNumber++;
                counter = 0;
                Push (i);
            } else {
                list[setNumber].Push (i);
                counter++;
            }
        }

        public int Pop () {
            int result = list[setNumber].Pop ();
            counter--;
            if (counter == 0) {
                counter = threshold;
                list.Remove (list[setNumber]);
                setNumber--;
            }
            return result;
        }

        internal int PopAt (int v) {
            int totalElement = setNumber * threshold + counter;
            int removeAmount = totalElement - (v + 1);
            Stack<int> stack = new Stack<int> ();

            for (int i = 0; i < removeAmount; i++) {
                stack.Push (Pop ());
            }
            int reuslt = Pop ();
            for (int i = 0; i < removeAmount; i++) {
                Push (stack.Pop ());
            }
            return reuslt;
        }
    }
}