using System;

namespace CrackingTheCode6th.Sort {
    public class QuickSort : Quiz {
        public override void Test () {
            int[] array = new int[10];
            Random rnd = new Random ();
            for (int i = 0; i < array.Length; i++) {
                array[i] = rnd.Next (1, 30);
            }
            System.Console.WriteLine ("Original Array");
            foreach (var item in array) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine ();
System.Console.WriteLine();
            ArrayQuickSort (array, 0, array.Length - 1);
            System.Console.WriteLine ("After Quick Sort Time: Avg. O(n(logn)), Worst O(n^2) / Space: O(n)");
            foreach (var item in array) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine ();
        }

        private void ArrayQuickSort (int[] array, int left, int right) {
            if (left >= right) {
                return;
            }
            
            foreach (var item in array) {
                System.Console.Write (item + " ");
            }
            
            
            int pivot = array[(left + right) / 2];
            int index = Partition (array, left, right, pivot);
            System.Console.Write("   Pivot: "+pivot+" Index: "+index);
            System.Console.WriteLine ();

            ArrayQuickSort (array, left, index - 1);
            ArrayQuickSort (array, index, right);

        }

        private int Partition (int[] array, int left, int right, int pivot) {
            while (left <= right) {
                while (array[left] < pivot) {
                    left++;
                }
                while (array[right] > pivot) {
                    right--;
                }
                if (left <= right) {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}