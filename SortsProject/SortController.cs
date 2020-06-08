using System;
using System.Collections.Generic;
using System.Text;

namespace SortsProject
{
    class SortController
    {
        ArrayProvider _arrayProvider;
        Dictionary<string, ISort> sortsDictionary;

        public SortController(ArrayProvider arrayProvider)
        {
            _arrayProvider = arrayProvider;
            sortsDictionary = new Dictionary<string, ISort>()
            {
                { "Bubble", new BubbleSort() },
                { "Quick", new QuickSort() },
                { "Insertion", new InsertionSort() },
                { "Merge", new MergeSort() },
                { "Shaker", new ShakerSort() }
            };
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

        public void SortArray(string sortName)
        {
            sortsDictionary[sortName].Sort(_arrayProvider.ArrayToSort);
        }
    }
}
