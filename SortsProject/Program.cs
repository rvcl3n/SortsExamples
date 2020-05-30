using System;
using System.Diagnostics;

namespace SortsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayProvider arrayProvider = new ArrayProvider(20);

            SortController sortController = new SortController(arrayProvider);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            sortController.ArraySetup();
            //sortController.BubleSort();
            //sortController.QuickSort();
            //new BubbleSort().Sort(arrayProvider.SortArray);
            //new QuickSort().Sort(arrayProvider.SortArray);
            //new InsertionSort().Sort(arrayProvider.SortArray);
            //new MergeSort().Sort(arrayProvider.SortArray);
            new ShakerSort().Sort(arrayProvider.SortArray);
            sortController.PrintArray();

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("Total Seconds: "+ts.TotalSeconds);

            Console.ReadKey();
        }
    }
}
