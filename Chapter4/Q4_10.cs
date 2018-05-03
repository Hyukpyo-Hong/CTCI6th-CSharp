using System;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_10 : Quiz {
        public override void Test () {
            Node a = new Node (1);
            Node b = new Node (1);
            Node c = new Node (3);
            Node d = new Node (4);
            Node e = new Node (5);
            Node f = new Node (5);
            BinaryTree t1 = new BinaryTree (a);
            a.Left = b;
            b.Left = c;
            b.Right = d;
            a.Right = e;
            e.Left = f;

            Node A = new Node (1);
            Node B = new Node (3);
            Node C = new Node (4);
            BinaryTree t2 = new BinaryTree (A);
            A.Left = B;
            A.Right = C;

            Boolean flag = false;
            FindSameRoot (t1.Root, t2.Root,flag);

            /*
            G1
                        1
                1               5
            3       4        5 

            G2
                        1
                    3       4

             */

        }

        private void FindSameRoot (Node n1, Node n2, Boolean flag) {
            if(flag || n1==null || n2==null){
                return;
            }
            if (n1.Value == n2.Value) {
                if (IsIdentical (n1, n2)) {
                    flag=true;
                    System.Console.WriteLine("Same Tree");
                    return;
                };
            }
            FindSameRoot (n1.Left, n2,flag);
            FindSameRoot (n1.Right, n2,flag);
        }

        private bool IsIdentical (Node n1, Node n2) {
            if(n1==null && n2==null) return true;
            else if(n1==null || n2==null) return false;
            else if(n1.Value!=n2.Value) return false;
            else return IsIdentical(n1.Left,n2.Left) && IsIdentical(n1.Right,n2.Right);
        }

        class Node {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node (int value) {
                Value = value;
            }
        }

        class BinaryTree {
            public Node Root { get; set; }
            public BinaryTree (Node node) {
                Root = node;
            }
        }
    }
}