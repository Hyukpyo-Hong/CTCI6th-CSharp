using System;

namespace CrackingTheCode6th.Others {
    public class CustomLinkedList : Quiz {

        public override void Test () {
            int count = 0;
            Node head = new Node (count++.ToString (), null);

            for (int i = 0; i < 5; i++) {
                InsertNode (head, count++.ToString ());
            }
            ShowLinkedList (head);
            DeleteNode (head, "3");
            ShowLinkedList (head);
            
        }

        private void DeleteNode (Node head, string v) {
            Node current = head;
            while (true) {
                if (current.val != v) {
                    current = current.next;
                } else if(current.val==v){
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                    System.Console.WriteLine("Delete Value "+v);
                    break;
                }
                if(current.next==null){
                    System.Console.WriteLine("Cannot find Value "+v);
                    break;
                }
            }

        }

        private void ShowLinkedList (Node head) {
            Node current = head;
            while (current.next != null) {
                System.Console.WriteLine (string.Format ("Prev:{0} - Val:{1} - Next:{2}", current.prev != null? current.prev.val: "", current.val, current.next != null? current.next.val: ""));
                current = current.next;
            }
            System.Console.WriteLine (string.Format ("Prev:{0} - Val:{1} - Next:{2}", current.prev != null? current.prev.val: "", current.val, current.next != null? current.next.val: ""));
        }

        private void InsertNode (Node head, string v) {
            Node current = head;
            while (current.next != null) {
                current = current.next;
            }
            current.next = new Node (v, current);
        }

    }

    class Node {
        public Node (string val, Node prev) {
            this.val = val;
            this.prev = prev;
            this.next = null;
        }
        public string val { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }

    }
}