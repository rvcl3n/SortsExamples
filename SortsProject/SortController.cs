using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace SortsProject
{
    class SortController
    {
        ArrayProvider _arrayProvider;
        Dictionary<string, ISort> sortsDictionary;
        Stopwatch stopWatch;

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

            stopWatch = new Stopwatch();
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

        public TimeSpan SortArray(string sortName)
        {
            _arrayProvider.FillArray();
            _arrayProvider.PrintArray();

            stopWatch.Restart();

            sortsDictionary[sortName].Sort(_arrayProvider.ArrayToSort);

            stopWatch.Stop();

            _arrayProvider.PrintArray();

            return stopWatch.Elapsed;
        }
    }
}
