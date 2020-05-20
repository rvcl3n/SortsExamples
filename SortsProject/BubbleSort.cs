using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class BubbleSort: ISort
    {
        public void Sort(int[] arrayToSort)
        {
            int a;
            int ind = arrayToSort.Length;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < ind; j++)
                {
                    if (j + 1 < ind && arrayToSort[j] > arrayToSort[j + 1])
                    {
                        a = arrayToSort[j + 1];
                        arrayToSort[j + 1] = arrayToSort[j];
                        arrayToSort[j] = a;

                    }
                }

                ind--;
            }
        }
    }
}
