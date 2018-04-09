using System.Collections.Generic;

namespace CrackingTheCode6th.DataStructure {
    public class BinaryTree<T> {
        public BinaryTreeNode<T> root { get; set; } = null;
        public virtual void Clear () {
            root = null;
        }
    }
    public class BinarySearchTree : BinaryTree<int> {
        public BinaryTreeNode<int> Insert (BinaryTreeNode<int> root, BinaryTreeNode<int> node) {
            if (root == null) {
                root = node;
            } else {
                if (node.Data <= root.Data) {
                    root.Left = Insert (root.Left, node);
                } else {
                    root.Right = Insert (root.Right, node);
                }
            }
            return root;
        }
    }
}