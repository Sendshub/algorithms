using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = CreateArray();
            array = InsertionSort.Sort(array);
            PrintArray(array);
        }

        private static int[] CreateArray()
        {
            return new int[10] { 100, 1, 4, 121, 100, 3, 400, 45, 56, 6 };
        }

        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
