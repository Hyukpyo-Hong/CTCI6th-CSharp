using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_9 : Quiz {
        public override void Test () {
            BST bst = new BST ();
            bst.Insert (5);
            bst.Insert (1);
            bst.Insert (7);
            BSTSequence (bst.Root, 0, new List<int[]> { new int[] { bst.Root.Value } });
            bst = new BST ();
            bst.Insert (5);
            bst.Insert (3);
            bst.Insert (7);
            bst.Insert (1);
            bst.Insert (4);
            bst.Insert (6);
            bst.Insert (9);
            BSTSequence (bst.Root, 0, new List<int[]> { new int[] { bst.Root.Value } });
        }

        private void BSTSequence (Node root, int degree, List<int[]> list) {
            if (root.Left != null || root.Right != null) {
                foreach (var item in list) {
                    if (item.Length == degree) {
                        if (root.Left != null && root.Right == null) {
                            item[item.Length] = root.Left.Value;
                        }else if (root.Left == null && root.Right != null) {

                        }else{

                        }
                    }
                }
            }

        }

        /*
        1)
            5
        1       7

        2)        
                      5
            3                   7
        1       4           6       9
                                       11

        */

        private class Node {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node (int value) {
                this.Value = value;
            }
        }

        private class BST {
            public Node Root { get; set; }
            public void Insert (int val) {
                if (Root == null) {
                    Root = new Node (val);
                } else {
                    Node temp = Root;
                    while (temp != null) {
                        if (val <= temp.Value) {
                            if (temp.Left == null) {
                                temp.Left = new Node (val);
                                break;
                            } else {
                                temp = temp.Left;
                            }
                        } else {
                            if (temp.Right == null) {
                                temp.Right = new Node (val);
                                break;
                            } else {
                                temp = temp.Right;
                            }
                        }
                    }
                }
            }
        }
    }
}