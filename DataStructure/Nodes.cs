using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CrackingTheCode6th.DataStructure {
    public class Node<T> {
        public T Data { get; set; }
        public NodeList<T> Neighbors { get; set; }
        public bool Visited { get; set; }
        public Node () { }
        public Node (T data) : this (data, null) { }
        public Node (T data, NodeList<T> neighbors) {
            this.Data = data;
            this.Neighbors = neighbors;
        }

    }

    public class NodeList<T> : Collection<Node<T>> {
        public NodeList () : base () { }
        public NodeList (int initialSize) {
            for (int i = 0; i < initialSize; i++) {
                base.Items.Add (default (Node<T>));
            }
        }
        public Node<T> FindByValue (T value) {
            foreach (Node<T> node in Items) {
                if (node.Data.Equals (value)) {
                    return node;
                }
            }
            return null;
        }
    }

    public class BinaryTreeNode<T> : Node<T> {
        public BinaryTreeNode () : base () { }
        public BinaryTreeNode (T data) : base (data, null) { }
        

        public BinaryTreeNode (T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right) {
            Data = data;
            NodeList<T> children = new NodeList<T> (2);
            children[0] = left;
            children[1] = right;
            Neighbors = children;
        }

        public BinaryTreeNode<T> Left {
            get {
                if (Neighbors == null) {
                    return null;
                } else {
                    return (BinaryTreeNode<T>) Neighbors[0];
                }
            }
            set {
                if (Neighbors == null) {
                    Neighbors = new NodeList<T> (2);
                }

                Neighbors[0] = value;
            }
        }

        public BinaryTreeNode<T> Right {
            get {
                if (Neighbors == null) {
                    return null;
                } else {
                    return (BinaryTreeNode<T>) Neighbors[1];
                }
            }
            set {
                if (Neighbors == null) {
                    Neighbors = new NodeList<T> (2);
                }

                Neighbors[1] = value;
            }
        }
    }

    public class GraphNode<T> : Node<T> {
        public List<int> Costs { get; set; } = new List<int> ();
        
        public GraphNode () : base () { }
        public GraphNode (T value) : base (value) { }
        public GraphNode (T value, NodeList<T> neighbors) : base (value, neighbors) { }
        new public NodeList<T> Neighbors {
            get {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T> ();

                return base.Neighbors;
            }
        }

    }
}