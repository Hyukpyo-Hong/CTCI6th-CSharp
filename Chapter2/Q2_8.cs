using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_8 : Quiz {
        class Node {
            public char value { get; set; }
            public Node (char value) {
                this.value = value;
            }
            public Node Next;

        }
        public override void Test () {

            Node a = new Node ('a');
            Node b = new Node ('b');
            Node c = new Node ('c');
            Node d = new Node ('d');
            Node e = new Node ('e');
            Node f = new Node ('f');
            Node g = new Node ('g');
            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = c;
            
            LoopDetection (a);

            g.Next = null;
            ShowList (a);
            LoopDetection (a);

            g.Next = a;
            LoopDetection (a);

        }

        private void LoopDetection (Node a1) {
            HashSet<Node> hash = new HashSet<Node> ();
            Node current = a1;
            while (current.Next != null) {
                if (!hash.Contains (current)) {
                    hash.Add (current);
                    current = current.Next;
                } else {
                    System.Console.WriteLine ("Loop is Started at Node whose value is " + current.value);
                    return;
                }
            }
            System.Console.WriteLine ("No Loop Detection");

        }

        private void ShowList (Node node) {
            Node current = node;
            while (current.Next != null) {
                System.Console.Write (current.value + "-");
                current = current.Next;
            }
            System.Console.WriteLine (current.value);

        }

    }

}