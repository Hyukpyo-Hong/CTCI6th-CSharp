using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_1 : Quiz {
        public override void Test () {
            LinkedList<char> list = new LinkedList<char> ();
            Random rnd = new Random ();
            for (int i = 0; i < 100; i++) {
                list.AddLast ((char) rnd.Next ((int)
                    'a', (int)
                    'z'));
            }
            ShowList (list);
            list = RemoveDuplicate(list);
            ShowList (list);

        }

        private LinkedList<char> RemoveDuplicate(LinkedList<char> list)
        {
            HashSet<char> hash = new HashSet<char>();
            foreach (var item in list)
            {
                hash.Add(item);
            }
            LinkedList<char> temp = new LinkedList<char> ();
            foreach (var item in hash)
            {
                temp.AddLast(item);
            }
            System.Console.WriteLine("Removed");
            return temp;

        }

        private void ShowList (LinkedList<char> list) {
            foreach (var item in list) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine();
        }
    }
}