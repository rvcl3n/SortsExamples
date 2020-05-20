using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class QuickSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            Sort(arrayToSort, 0, arrayToSort.Length - 1);

        }

        void Sort(int[] array, int leftInd, int rightInd)
        {
            if (leftInd >= rightInd)
                return;

            int pivot = array[(leftInd + rightInd) / 2];
            int index = Partition(array, leftInd, rightInd, pivot);
            Sort(array, leftInd, index - 1);
            Sort(array, index, rightInd);
        }

        int Partition(int[] array, int leftInd, int rightInd, int pivot)
        {
            while (leftInd <= rightInd)
            {
                while (array[leftInd] < pivot)
                {
                    leftInd++;
                }

                while (array[rightInd] > pivot)
                {
                    rightInd--;
                }

                if (leftInd <= rightInd)
                {
                    Swap(array, leftInd, rightInd);
                    leftInd++;
                    rightInd--;
                }
            }

            return leftInd;
        }

        void Swap(int[] array, int leftInd, int rightInd)
        {
            int a = array[leftInd];
            array[leftInd] = array[rightInd];
            array[rightInd] = a;
        }
    }
}
