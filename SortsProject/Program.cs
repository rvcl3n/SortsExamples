using System;
using System.Diagnostics;

namespace SortsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProvider arrayProvider = new ArrayProvider(20);
            SortController sortController = new SortController(arrayProvider);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            sortController.ArraySetup();

            sortController.SortArray("Bubble");

            sortController.PrintArray();

            sortController.ArraySetup();

            sortController.SortArray("Quick");

            sortController.PrintArray();

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("Total Seconds: "+ts.TotalSeconds);

            Console.ReadKey();
        }
    }
}
