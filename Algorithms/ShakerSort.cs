using System;
namespace Algorithms
{
    public static class ShakerSort
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("ShakerSorting");

            int left = 0, right = array.Length - 1, count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;

                    if (array[i] > array[i + 1])
                    {
                        Manipulation<int>.Swap(array, i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    count++;

                    if (array[i - 1] > array[i])
                    {
                        Manipulation<int>.Swap(array, i - 1, i);
                    }
                }

                left++;
            }

            return array;
        }
    }
}
