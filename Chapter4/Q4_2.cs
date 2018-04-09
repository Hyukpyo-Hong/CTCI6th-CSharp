using System;
using System.Collections.Generic;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_2 : Quiz {

        BinarySearchTree tree = new BinarySearchTree ();
        public override void Test () {
            int[] array = new int[10];
            HashSet<int> hash = new HashSet<int> ();
            for (int i = 0; i < array.Length; i++) {
                array[i] = i;
            }

            tree.root = tree.Insert (null, CreateBST (array, 0, array.Length - 1));
            ShowBST (tree);

        }

        private void ShowBST (BinarySearchTree tree) {
            Queue<BinaryTreeNode<int>> queue = new Queue<BinaryTreeNode<int>> ();
            queue.Enqueue (tree.root);
            while (queue.Count != 0) {
                BinaryTreeNode<int> temp = queue.Dequeue ();
                System.Console.Write (temp.Data + " ");
                if (temp.Left != null) queue.Enqueue (temp.Left);
                if (temp.Right != null) queue.Enqueue (temp.Right);
            }
            System.Console.WriteLine ();
        }

        private BinaryTreeNode<int> CreateBST (int[] array, int start, int end) {
            if (start > end) {
                return null;
            }
            int mid = (int) Math.Ceiling ((start + end) / 2.0);
            BinaryTreeNode<int> root = new BinaryTreeNode<int> ();
            root.Data = array[mid];
            root.Left = CreateBST (array, start, mid - 1);
            root.Right = CreateBST (array, mid + 1, end);
            return root;
        }
    }
}