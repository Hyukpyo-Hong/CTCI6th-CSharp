using System;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_1 : Quiz {
        int numberOfStack = 3;
        int stackCapacity = 5;
        int[] stacks;
        int[] indexOfTop;
        public override void Test () {

            Initialize ();

            //Push
            Random rnd = new Random ();
            for (int i = 0; i < numberOfStack; i++) {
                for (int j = 0; j < stackCapacity; j++) {
                    Push (i, rnd.Next (i, 100));
                }
            }

            //Push when stack is full
            for (int i = 0; i < numberOfStack; i++) {
                Push (i, rnd.Next (1, 100));
            }

            for (int i = 0; i < numberOfStack; i++) {
                ShowStack (i);
            }

            for (int i = 0; i < numberOfStack; i++) {
                Peek (i);
            }

            for (int i = 0; i < numberOfStack; i++) {
                System.Console.WriteLine ("Stack #" + numberOfStack + " Pop");
                for (int j = 0; j < stackCapacity; j++) {
                    System.Console.WriteLine (Pop (i));
                }
            }

            for (int i = 0; i < numberOfStack; i++) {
                Pop (i);
            }

            for (int i = 0; i < numberOfStack; i++) {
                ShowStack (i);
            }

        }

        private void Initialize () {
            stacks = new int[numberOfStack * stackCapacity];
            indexOfTop = new int[numberOfStack];
            for (int i = 0; i < numberOfStack; i++) {
                indexOfTop[i] = (i * stackCapacity) - 1;
            }
        }

        private bool IsEmpty (int stackNumber) {
            if (indexOfTop[stackNumber] == (stackNumber * stackCapacity) - 1) {
                return true;
            } else {
                return false;
            }
        }

        private bool IsFull (int stackNumber) {
            if (indexOfTop[stackNumber] == ((stackNumber + 1) * stackCapacity) - 1) {
                return true;
            } else {
                return false;
            }
        }

        private int Pop (int stackNumber) {
            if (!IsEmpty (stackNumber)) {
                int pop = stacks[indexOfTop[stackNumber]];
                indexOfTop[stackNumber]--;
                return pop;
            } else {
                System.Console.WriteLine ("Can't Pop. Stack #" + stackNumber + " is Empty.");
                return 0; // For test continue, in Real it should be Exception
            }
        }

        private void Peek (int stackNumber) {
            System.Console.WriteLine ("Stack #" + stackNumber + " Peek: " + stacks[indexOfTop[stackNumber]]);
        }

        private void ShowStack (int stackNumber) {
            System.Console.WriteLine ("Stack #" + stackNumber);
            for (int i = stackNumber * stackCapacity; i <= indexOfTop[stackNumber]; i++) {
                System.Console.Write (stacks[i] + " ");
            }
            System.Console.WriteLine ();
        }
        private void Push (int stackNumber, int Value) {
            if (!IsFull (stackNumber)) {

                indexOfTop[stackNumber]++;
                stacks[indexOfTop[stackNumber]] = Value;
            } else {
                System.Console.WriteLine ("Can't Push. Stack #" + stackNumber + " is Full.");
            }
        }
    }
}