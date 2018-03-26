using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter2 {
    public class Q2_7 : Quiz {
        public class Node {
            public int value { get; set; }
            public Node (int value) {
                this.value = value;
            }
            public Node Next;

        }
        public override void Test () {
            Random rnd = new Random ();
            Node a1 = new Node (1);
            Node a2 = new Node (2);
            Node a3 = new Node (3);
            Node b1 = new Node (4);
            Node b2 = new Node (5);
            Node b3 = new Node (6);
            Node c1 = new Node (7);
            Node c2 = new Node (8);
            Node c3 = new Node (9);

            a1.Next = a2;
            a2.Next = a3;
            a3.Next = c1;
            c1.Next = c2;
            c2.Next = c3;
            b1.Next = b2;
            b2.Next = b3;
            b3.Next = c1;

            ShowList (a1);
            ShowList (b1);
            IsIntersection (a1, b1);

            a3.Next = b1;
            ShowList (a1);
            ShowList (b1);
            IsIntersection (a1, b1);

            ShowList (b1);
            ShowList (a1);
            IsIntersection (b1, a1);

            Node t = new Node (3);
            ShowList (a1);
            ShowList (t);
            IsIntersection (a1, t);

        }

        private void IsIntersection (Node a1, Node b1) {
            Stack<Node> first = new Stack<Node> ();
            Stack<Node> second = new Stack<Node> ();
            Node current = a1;
            while (current.Next != null) {
                first.Push (current);
                current = current.Next;
            }
            first.Push (current);

            current = b1;
            while (current.Next != null) {
                second.Push (current);
                current = current.Next;
            }
            second.Push (current);

            if (first.Pop () != second.Pop ()) {
                System.Console.WriteLine ("Not Intersection");
            } else {
                bool flag = true;
                while (first.Count != 0 && second.Count != 0) {
                    if (first.Pop () != second.Pop ()) {
                        System.Console.WriteLine ("Intersection Node has value: " + first.Pop ().Next.Next.value);
                        flag = false;
                        break;
                    }
                }
                if (flag) {
                    if (first.Count == 0 && second.Count != 0) {
                        System.Console.WriteLine ("Intersection Node has value: " + second.Pop ().Next.value);
                    } else if (first.Count != 0 && second.Count == 0) {
                        System.Console.WriteLine ("Intersection Node has value: " + first.Pop ().Next.value);
                    } else {
                        System.Console.WriteLine ("Intersection Node has value: " + a1.value);
                    }
                }

            }

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