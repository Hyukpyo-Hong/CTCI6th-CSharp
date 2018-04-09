using System;
using System.Collections.Generic;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_3 : Quiz {
        public override void Test () {
            BinaryTree<char> tree = new BinaryTree<char> ();
            tree.root = new BinaryTreeNode<char> ('r');
            BinaryTreeNode<char> a = new BinaryTreeNode<char> ('a');
            BinaryTreeNode<char> b = new BinaryTreeNode<char> ('b');
            BinaryTreeNode<char> c = new BinaryTreeNode<char> ('c');
            BinaryTreeNode<char> d = new BinaryTreeNode<char> ('d');
            BinaryTreeNode<char> e = new BinaryTreeNode<char> ('e');
            BinaryTreeNode<char> f = new BinaryTreeNode<char> ('f');
            BinaryTreeNode<char> g = new BinaryTreeNode<char> ('g');

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

            List<List<char>> result = GetLinkedList (tree);
            ShowResult (result);

        }

        private void ShowResult (List<List<char>> result) {
            for (int i = 0; i < result.Count; i++) {
                System.Console.WriteLine ("#" + i + " List");
                foreach (var item in result[i]) {
                    System.Console.Write (item + " ");
                }
                System.Console.WriteLine ();
            }
        }

        private List<List<char>> GetLinkedList (BinaryTree<char> tree) {
            List<List<char>> result = new List<List<char>> ();

            result.Add(new List<char> ());
            result[0].Add (tree.root.Data);
            GetLinkedList (result, tree.root.Left, 1);
            GetLinkedList (result, tree.root.Right, 1);

            return result;
        }

        private void GetLinkedList (List<List<char>> result, BinaryTreeNode<char> root, int level) {
            if (root == null) {
                return;
            }
            List<char> currentList;
            if (result.Count <= level) {
                currentList = new List<char> ();
                result.Add(currentList);
            } else {
                currentList = result[level];
            }
            currentList.Add (root.Data);
            GetLinkedList (result, root.Left, level+1);
            GetLinkedList (result, root.Right, level+1);
        }

    }
}
