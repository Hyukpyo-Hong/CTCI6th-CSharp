using System;

namespace CrackingTheCode6th.Sort {
    public class MergeSort : Quiz {
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

            ArrayMergeSort (array, new int[array.Length], 0, array.Length - 1);
            System.Console.WriteLine ("After Merge Sort Time: O(n(logn)) / Space: O(n)");
            foreach (var item in array) {
                System.Console.Write (item + " ");
            }
            System.Console.WriteLine ();
        }

        private void ArrayMergeSort (int[] array, int[] tempArray, int leftStart, int rightEnd) {
            if (leftStart < rightEnd) {
                int mid = (leftStart + rightEnd) / 2;
                ArrayMergeSort (array, tempArray, leftStart, mid);
                ArrayMergeSort (array, tempArray, mid + 1, rightEnd);
                Merge (array, tempArray, leftStart, mid, rightEnd);
            } else {
                return;
            }

        }

        private void Merge (int[] array, int[] tempArray, int leftStart, int mid, int rightEnd) {
            int leftIdx = leftStart;
            int rightIdx = mid + 1;
            int tempIdx = leftStart;
            while ((leftIdx <= mid) && (rightIdx <= rightEnd)) {
                if (array[leftIdx] < array[rightIdx]) {
                    tempArray[tempIdx++] = array[leftIdx++];
                } else {
                    tempArray[tempIdx++] = array[rightIdx++];
                }
            }

            if (leftIdx <= mid) {
                Array.Copy (array, leftIdx, tempArray, tempIdx, mid - leftIdx + 1);
            }
            if (rightIdx <= rightEnd) {
                Array.Copy (array, rightIdx, tempArray, tempIdx, rightEnd - rightIdx + 1);
            }
            Array.Copy (tempArray, leftStart, array, leftStart, rightEnd - leftStart + 1);

        }
    }
}