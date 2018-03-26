using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_5 : Quiz {
        public override void Test () {
            LinkedList<int> first = new LinkedList<int> ();
            LinkedList<int> second = new LinkedList<int> ();

            first.AddLast (7);
            first.AddLast (1);
            first.AddLast (6);
            second.AddLast (5);
            second.AddLast (9);
            second.AddLast (2);
            LinkedList<int> result = SumList (first, second);
            foreach (var item in result) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine();
        }

        private LinkedList<int> SumList (LinkedList<int> first, LinkedList<int> second) {
            int sum = 0;
            int multiple = 1;
            foreach (var item in first) {
                sum += item * multiple;
                multiple *= 10;
            }
            multiple = 1;
            foreach (var item in second) {
                sum += item * multiple;
                multiple *= 10;
            }

            LinkedList<int> sumList = new LinkedList<int> ();                       
            foreach (var item in sum.ToString ()) {                
                sumList.AddFirst (Int32.Parse(item.ToString()));
            }
            return sumList;

        }
    }
}