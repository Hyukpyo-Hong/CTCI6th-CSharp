using System;
using System.Diagnostics;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_8 : Quiz {
        public override void Test () {
            Node<char> a = new Node<char> ('a');
            Node<char> b = new Node<char> ('b');
            Node<char> c = new Node<char> ('c');
            Node<char> d = new Node<char> ('d');
            Node<char> e = new Node<char> ('e');
            Node<char> f = new Node<char> ('f');
            a.InsertLeft (b);
            a.InsertRight (c);
            b.InsertLeft (d);
            b.InsertRight (e);
            c.InsertRight (f);

            System.Console.WriteLine (FindCommonAncestor (e, f) == 'a');
            a.Clear();
            System.Console.WriteLine (FindCommonAncestor (d, e) == 'b');
            a.Clear();
            System.Console.WriteLine (FindCommonAncestor (c, f) == 'c');
            a.Clear();

            /*
                  a
                /   \
                b    c    
               / \    \
              d   e    f

            e:f = a
            d:e = b
            c:f = c
             */
        }

        private char FindCommonAncestor (Node<char> e, Node<char> f) {
            Node<char> temp = e;
            while (temp != null) {
                temp.Visited = true;
                temp = temp.Parent;
            }
            temp = f;
            while (temp.Visited != true && temp != null) {
                temp.Visited = true;
                temp = temp.Parent;
            }
            return temp.Value;
        }

        private class Node<T> {
            public T Value { get; set; }
            public Node<T> Parent { get; set; }
            public bool Visited { get; set; } = false;
            private Node<T> Left { get; set; }
            private Node<T> Right { get; set; }
            public Node (T Value) {
                this.Value = Value;
            }
            public void InsertLeft (Node<T> node) {
                this.Left = node;
                node.Parent = this;
            }
            public void InsertRight (Node<T> node) {
                this.Right = node;
                node.Parent = this;
            }
            public void Clear () {
                this.Visited = false;
                if (this.Left != null) {                    
                    this.Left.Clear();                    
                }
                if (this.Right != null) {                    
                    this.Right.Clear();
                }
            }
        }
    }
}