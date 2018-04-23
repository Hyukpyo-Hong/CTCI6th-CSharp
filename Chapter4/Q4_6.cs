using System;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_6 : Quiz {
        public override void Test () {
            BST tree = new BST ();
            BSTNode a = new BSTNode (10);
            BSTNode b = new BSTNode (5);
            BSTNode c = new BSTNode (15);
            BSTNode d = new BSTNode (2);
            BSTNode e = new BSTNode (7);
            BSTNode f = new BSTNode (12);
            BSTNode g = new BSTNode (20);
            BSTNode h = new BSTNode (1);
            BSTNode i = new BSTNode (3);
            BSTNode j = new BSTNode (6);
            BSTNode k = new BSTNode (8);
            BSTNode l = new BSTNode (11);
            BSTNode m = new BSTNode (14);
            BSTNode n = new BSTNode (18);
            BSTNode o = new BSTNode (22);
            tree.Insert (a);
            tree.Insert (b);
            tree.Insert (c);
            tree.Insert (d);
            tree.Insert (e);
            tree.Insert (f);
            tree.Insert (g);
            tree.Insert (h);
            tree.Insert (i);
            tree.Insert (j);
            tree.Insert (k);
            tree.Insert (l);
            tree.Insert (m);
            tree.Insert (n);
            tree.Insert (o);
            System.Console.WriteLine ("Input " + a.Value);
            NextNodeInOrder (a);
            System.Console.WriteLine ("Input " + k.Value);
            NextNodeInOrder (k);
            System.Console.WriteLine ("Input " + o.Value);
            NextNodeInOrder (o);
            System.Console.WriteLine ("Input " + e.Value);
            NextNodeInOrder (e);

        }

        private void NextNodeInOrder (BSTNode node) {
            //Has Right Sub Tree
            if (node.Right != null) {
                LeftMostNode (node.Right);
            } else {
                //No Right Subtree
                if (node.Parent != null) {
                    BSTNode temp = node.Parent;
                    while (node.Value > temp.Value) {
                        if (temp.Parent == null) {
                            System.Console.WriteLine ("None");
                            return;
                        }
                        temp = temp.Parent;
                    }
                    System.Console.WriteLine (temp.Value);
                }

            }

        }

        private void LeftMostNode (BSTNode node) {
            BSTNode temp = node;
            while (temp != null) {
                if (temp.Left == null) {
                    System.Console.WriteLine (temp.Value);
                }
                temp = temp.Left;
            }

        }
    }

    //                  10
    //         5                  15
    //     2       7          12      20
    // 1      3  6    8     11  14   18  22

}