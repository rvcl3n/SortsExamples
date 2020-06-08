using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortsProject
{
    class ArrayProvider
    {
        private int[] array;
        Random rand = new Random();

        public ArrayProvider(int arraySize)
        {
            array = new int[arraySize];
        }

        public int[] ArrayToSort
        {
            get { return array; }
            set { array = value; }
        }


        public void MixArray()
        {

        }

        public void FillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array Length: " + array.Length + " Min: " +array.Min() + " Max: " + array.Max());

        }

    }
}
