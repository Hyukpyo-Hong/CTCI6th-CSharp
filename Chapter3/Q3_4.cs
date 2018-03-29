using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_4 : Quiz {
        public override void Test () {

            MyQueue queue = new MyQueue ();
            for (int i = 0; i < 10; i++) {
                queue.Enqueue (i);
                System.Console.Write (i + " ");
            }
            System.Console.WriteLine ();
            for (int i = 0; i < 10; i++) {
                System.Console.WriteLine (queue.Dequeue ());
            }

        }
    }

    internal class MyQueue {
        Stack<int> one = new Stack<int> ();
        Stack<int> two = new Stack<int> ();

        internal int Dequeue () {
            return two.Pop ();            
        }

        internal void Enqueue (int i) {
            while (two.Count != 0) {
                one.Push (two.Pop ());
            }
            one.Push (i);
            while (one.Count != 0) {
                two.Push (one.Pop ());
            }
        }

    }
}