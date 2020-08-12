using System;

namespace SortsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProvider arrayProvider = new ArrayProvider(200);
            SortController sortController = new SortController(arrayProvider);

            sortController.DisplayAvailableSorts();

            while (true)
            {
                Console.WriteLine("Enter the sort:");
                string sortName = Console.ReadLine();

                TimeSpan SortoingTime = sortController.SortArray(sortName);

                Console.WriteLine("Total Seconds: " + SortoingTime);
                Console.ReadKey();
            }
        }
    }
}
