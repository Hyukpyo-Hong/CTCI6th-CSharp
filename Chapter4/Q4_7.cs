using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_7 : Quiz {
        public override void Test () {
            GraphNode<char> a = new GraphNode<char> ('a');
            GraphNode<char> b = new GraphNode<char> ('b');
            GraphNode<char> c = new GraphNode<char> ('c');
            GraphNode<char> d = new GraphNode<char> ('d');
            GraphNode<char> e = new GraphNode<char> ('e');
            GraphNode<char> f = new GraphNode<char> ('f');
            GraphNode<char> g = new GraphNode<char> ('g');
            Graph<char> graph = new Graph<char> ();
            graph.Insert (a);
            graph.Insert (b);
            graph.Insert (c);
            graph.Insert (d);
            graph.Insert (e);
            graph.Insert (f);
            a.Insert (d);
            f.Insert (b);
            b.Insert (d);
            f.Insert (a);
            d.Insert (c);
            b.Insert(e);
            b.Insert(g);
            //e.Insert(f); 
            
/*
          f        
          /\  
         a  b
         \ /|\
          d | e
          | |
          c g
*/
            

            List<char> result = new List<char> ();
            foreach (var node in graph.nodes) {
                BuildOrder (node, result);
            }

            foreach (char item in result) {
                System.Console.Write (item + " ");
            }
        }

        public enum Status { OnProcess, Finished, NotWorked }
        private void BuildOrder (GraphNode<char> root, List<char> result) {
            if (root.Status!=Status.Finished) {
                root.Status=Status.OnProcess;
                foreach (var item in root.Neighbor) {
                    if(item.Status==Status.OnProcess){
                        throw new Exception(item.Value+" is Cycled");
                    }
                    if (item.Status!=Status.Finished) {
                        BuildOrder (item, result);
                    }
                }
                if (root.Status!=Status.Finished) {
                    result.Add (root.Value);
                    root.Status = Status.Finished;
                }
            }
        }

        public class Graph<T> {
            public HashSet<GraphNode<T>> nodes { get; set; } = new HashSet<GraphNode<T>> ();
            public void Insert (GraphNode<T> node) {
                nodes.Add (node);
            }
        }
        public class GraphNode<T> {
            public T Value { get; set; }
            public Status Status { get; set; } = Status.NotWorked;
            public List<GraphNode<T>> Neighbor { get; set; } = new List<GraphNode<T>> ();
            public GraphNode (T value) {
                this.Value = value;
            }
            public void Insert (GraphNode<T> node) {
                Neighbor.Add (node);
            }
        }
    }

}