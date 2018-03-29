using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_2 : Quiz {
        public override void Test () {
            int currentMin = Int32.MaxValue;
            Stack<int> stack = new Stack<int> ();
            Stack<int> tracker = new Stack<int> ();

            Random rnd = new Random ();
            int random;
            for (int i = 0; i < 10; i++) {
                random = rnd.Next (1, 10);
                if (random <= currentMin) {
                    currentMin = random;
                    tracker.Push (currentMin);
                }
                stack.Push (random);
                System.Console.Write (random + " ");
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ("Stack Lengh:" + stack.Count);
            System.Console.WriteLine ("Tracker Lengh:" + tracker.Count);

            for (int i = 0; i < 10; i++) {
                System.Console.WriteLine ("Current Min: " + tracker.Peek ());
                int num = stack.Pop ();
                if (num == tracker.Peek ()) {
                    tracker.Pop ();
                }
            }
        }
    }
}