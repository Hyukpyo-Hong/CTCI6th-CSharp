using System;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    enum k { a, b, c };

 public class Q4_5 : Quiz {
 public override void Test () {
 BinaryTree<int> tree = new BinaryTree<int> (); 
 BinaryTreeNode<int> r = new BinaryTreeNode<int> (1);
 BinaryTreeNode<int> a = new BinaryTreeNode<int> (2);
 BinaryTreeNode<int> b = new BinaryTreeNode<int> (3);
 BinaryTreeNode<int> c = new BinaryTreeNode<int> (4);
 BinaryTreeNode<int> d = new BinaryTreeNode<int> (5);
 BinaryTreeNode<int> e = new BinaryTreeNode<int> (6);
 BinaryTreeNode<int> f = new BinaryTreeNode<int> (7);
 BinaryTreeNode<int> g = new BinaryTreeNode<int> (8);

 tree.root = r;
 tree.root.Left = a;
 tree.root.Right = b;
 a.Left = c;
 a.Right = d;
 b.Left = e;
 b.Right = f;
 f.Right = g;

 /* Tree Structure

 1
 2               3
 4       5       6       7
 8

 Tree Structure */

 BinarySearchTree tree2 = new BinarySearchTree ();
 tree2.root = tree2.Insert (null, new BinaryTreeNode<int> (10));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (5));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (2));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (3));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (6));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (7));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (15));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (12));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (13));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (19));
 tree2.Insert (tree2.root, new BinaryTreeNode<int> (20));
 /* Tree Structure
 10
 5                 15
 2       6       12          19
 3        7        13           20

 Tree Structure */

 IsBST (tree);
 IsBST (tree2);

        }

        private void IsBST (BinaryTree<int> tree) {

            if (IsBST (tree.root, 0) > 0) {
                System.Console.WriteLine ("Not BST");
            } else {
                System.Console.WriteLine ("BST");
            }

        }

        private int IsBST (BinaryTreeNode<int> root, int flag) {
            if (root != null) {
                if (root.Left != null) {
                    if (root.Data < root.Left.Data) return 1;
                }
                if (root.Right != null) {
                    if (root.Data >= root.Right.Data) return 1;
                }
                return IsBST (root.Left, flag) + IsBST (root.Right, flag);
            } else {
                return 0;
            }
        }

    }
}