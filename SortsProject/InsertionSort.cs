using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class InsertionSort : ISort
    {
        public void Sort(int[] arrayToSort)
        {
            int key, i;

            for (int j = 1; j < arrayToSort.Length; j++)
            {
                key = arrayToSort[j];
                i = j - 1;
                while (i >= 0 && arrayToSort[i] > key)
                {
                    arrayToSort[i + 1] = arrayToSort[i];
                    i = i - 1;
                }
                arrayToSort[i + 1] = key;
            }
        }
    }
}
