using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class ShakerSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            int left = 0;
            int right = arrayToSort.Length - 1;

            while(left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if(arrayToSort[i] > arrayToSort[i + 1])
                        Swap(arrayToSort, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (arrayToSort[i] < arrayToSort[i - 1])
                        Swap(arrayToSort, i - 1, i);
                }
                left++;
            }        
        }

        void Swap(int[] array, int firstInd, int secondInd)
        {
            int temp = array[secondInd];
            array[secondInd] = array[firstInd];
            array[firstInd] = temp;
        }
    }
}
