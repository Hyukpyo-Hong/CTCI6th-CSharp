using System;
using System.Collections.Generic;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_4 : Quiz {
        public override void Test () {
            BinaryTree<char> tree = new BinaryTree<char> ();

            BinaryTreeNode<char> r = new BinaryTreeNode<char> ('r');
            BinaryTreeNode<char> a = new BinaryTreeNode<char> ('a');
            BinaryTreeNode<char> b = new BinaryTreeNode<char> ('b');
            BinaryTreeNode<char> c = new BinaryTreeNode<char> ('c');
            BinaryTreeNode<char> d = new BinaryTreeNode<char> ('d');
            BinaryTreeNode<char> e = new BinaryTreeNode<char> ('e');
            BinaryTreeNode<char> f = new BinaryTreeNode<char> ('f');
            BinaryTreeNode<char> g = new BinaryTreeNode<char> ('g');

            tree.root = r;
            tree.root.Left = a;
            tree.root.Right = b;
            a.Left = c;
            a.Right = d;
            b.Left = e;
            b.Right = f;
            f.Right = g;

            /* Tree Structure

                        r
                a               b
            c       d       e       f
                                        g

            Tree Structure */
            IsBalanced (tree);

            /* Tree Structure

                        r
                a               b
                    d       e       f
                                        g
                                    c

            Tree Structure */
            a.Left = null;
            g.Left = c;
            IsBalanced (tree);
        }

        private void IsBalanced (BinaryTree<char> tree) {
            int left = GetHeight (tree.root, "left");
            int right = GetHeight (tree.root, "right");
            System.Console.WriteLine ("Left Height: " + left + " Right Height: " + right);
            if (Math.Abs (left - right) > 1) {
                System.Console.WriteLine ("Not Balanced");
            } else {
                System.Console.WriteLine ("Balanced");
            }
        }

        private int GetHeight (BinaryTreeNode<char> root, string type) {
            BinaryTreeNode<char> startNode;
            Stack<int> stack = new Stack<int> ();
            stack.Push(0);
            if (type == "left") {
                startNode = root.Left;
            } else {
                startNode = root.Right;
            }
            GetHeight (startNode, stack, 0);

            return stack.Peek ();
        }

        private void GetHeight (BinaryTreeNode<char> startNode, Stack<int> stack, int level) {
            if (startNode == null) {
                return;
            }

            if (stack.Peek () < level) {
                stack.Push (level + 1);
            }
            GetHeight (startNode.Left, stack, level + 1);
            GetHeight (startNode.Right, stack, level + 1);
        }
    }
}