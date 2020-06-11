using System;

namespace SortsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProvider arrayProvider = new ArrayProvider(200);
            SortController sortController = new SortController(arrayProvider);

            TimeSpan SortoingTime = sortController.SortArray("Bubble");

            Console.WriteLine("Total Seconds: "+ SortoingTime);

            Console.ReadKey();
        }
    }
}
