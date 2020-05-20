using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class SortController
    {
        ArrayProvider _arrayProvider;
        int[] array;

        public SortController(ArrayProvider arrayProvider)
        {
            _arrayProvider = arrayProvider;
        }

        public void ArraySetup()
        {
            _arrayProvider.FillArray();
            _arrayProvider.PrintArray();
        }

        public void PrintArray()
        {
            _arrayProvider.PrintArray();
        }

        public void BubleSort()
        {
            array = _arrayProvider.SortArray;

            int a = 0;
            int ind = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < ind; j++)
                {
                    if (j + 1 < ind && array[j] > array[j + 1])
                    {
                        a = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = a;

                    }
                }

                ind--;
            }

            _arrayProvider.SortArray = array;
        }

        public void QuickSort()
        {
            array = _arrayProvider.SortArray;
            QuickSort(array, 0, array.Length - 1);

        }

        public void QuickSort(int[] array, int leftInd, int rightInd)
        {
            if (leftInd >= rightInd)
                return;

            int pivot = array[(leftInd + rightInd) / 2];
            int index = Partition(array, leftInd, rightInd, pivot);
            QuickSort(array, leftInd, index-1);
            QuickSort(array, index, rightInd);
        }

        int Partition(int[] array, int leftInd, int rightInd, int pivot)
        {
            while(leftInd<=rightInd)
            {
                while(array[leftInd]<pivot)
                {
                    leftInd++;
                }

                while (array[rightInd] > pivot)
                {
                    rightInd--;
                }

                if(leftInd <= rightInd)
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
