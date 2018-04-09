using System;
using System.Collections.Generic;
using CrackingTheCode6th.DataStructure;

namespace CrackingTheCode6th.Chapter4 {
    public class Q4_1 : Quiz {
        public override void Test () {

            GraphNode<char> a = new GraphNode<char> ('a');
            GraphNode<char> b = new GraphNode<char> ('b');
            GraphNode<char> c = new GraphNode<char> ('c');
            GraphNode<char> d = new GraphNode<char> ('d');
            GraphNode<char> e = new GraphNode<char> ('e');
            Graph<char> graph = new Graph<char> ();
            graph.AddNode (a);
            graph.AddNode (b);
            graph.AddNode (c);
            graph.AddNode (d);
            graph.AddNode (e);

            graph.AddDirectedEdge (a, b, 0);
            graph.AddDirectedEdge (b, c, 0);
            graph.AddDirectedEdge (c, d, 0);
            graph.AddDirectedEdge (d, a, 0);
            graph.AddDirectedEdge (a, c, 0);
            graph.AddDirectedEdge (e, a, 0);

            IsRouteBetween (a, e);
            IsRouteBetween (a, d);

        }

        private void IsRouteBetween (GraphNode<char> a, GraphNode<char> e) {
            bool result = false;
            Queue<GraphNode<char>> queue = new Queue<GraphNode<char>> ();
            a.Visited = true;
            queue.Enqueue (a);
            while (queue.Count != 0) {
                GraphNode<char> test = queue.Dequeue ();
                if (test == e) {
                    result = true;
                    break;
                }
                foreach (GraphNode<char> node in test.Neighbors) {
                    if (!node.Visited) {
                        queue.Enqueue (node);
                    }
                }
            }

            if (result) {
                System.Console.WriteLine ("There is route.");
            } else {
                System.Console.WriteLine ("There is noroute.");
            }
        }
    }
}