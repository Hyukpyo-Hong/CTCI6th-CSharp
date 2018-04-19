namespace CrackingTheCode6th.DataStructure {
    public class BST {
        public BSTNode Root { get; set; }
        public void Insert (BSTNode node) {
            if (Root == null) {
                Root = node;
            } else {
                Root.Insert (node);
            }
        }
        public void PostorderTraverse (BSTNode root) {
            if (root != null) {
                PostorderTraverse (root.Left);
                PostorderTraverse (root.Right);
                System.Console.Write (root.Value + " ");
            }
        }

        public void PreorderTraverse (BSTNode root) {
            if (root != null) {
                System.Console.Write (root.Value + " ");
                PreorderTraverse (root.Left);
                PreorderTraverse (root.Right);
            }
        }

        public void InorderTraverse (BSTNode root) {
            if (root != null) {
                InorderTraverse (root.Left);
                System.Console.Write (root.Value + " ");
                InorderTraverse (root.Right);
            }
        }
    }

    public class BSTNode {
        public BSTNode Parent { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
        public int Value { get; set; }
        public BSTNode (int value) {
            this.Value = value;
        }

        internal void Insert (BSTNode node) {
            if (node.Value <= this.Value) {
                if (Left != null) {
                    Left.Insert (node);
                } else {
                    Left = node;
                    node.Parent = this;
                }
            } else {
                if (Right != null) {
                    Right.Insert (node);
                } else {
                    Right = node;
                    node.Parent = this;
                }
            }
        }
    }
}