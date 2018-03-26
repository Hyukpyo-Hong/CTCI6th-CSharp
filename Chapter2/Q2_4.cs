using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_4 : Quiz {
        public override void Test () {
            LinkedList<int> list = new LinkedList<int> ();
            Random rnd = new Random ();
            for (int i = 0; i < 10; i++) {
                list.AddLast (rnd.Next (1, 10));
            }
            ShowList(list);
            list = Partition(list,5);
            ShowList(list);

        }

        private LinkedList<int> Partition(LinkedList<int> list, int v)
        {
            LinkedList<int> temp = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            foreach (var item in list)
            {
                if(item<v){
                    temp.AddLast(item);
                }else{
                    stack.Push(item);
                }
            }
            foreach (var item in stack)
            {
                temp.AddLast(item);
            }
            System.Console.WriteLine("Partition by "+v);
            return temp;
        }

        private void ShowList(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                System.Console.Write(item+" ");
            }
            System.Console.WriteLine();
        }
    }
}