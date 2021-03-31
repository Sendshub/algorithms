// Быстрая сортировка – алгоритм сортировки, который является наиболее быстрым из известных
// методов сортировки массива со степенью роста сложности О(n log n).
// Этапы сортировки:
// • Случайный выбор опорного элемента массива (pivotValue), относительно которого
// переупорядочиваются элементы массива.
// • Переместить все значения, которые больше опорного, вправо, а все значения, что меньше
// опорного, влево.
// • Повторить алгоритм для неотсортированной левой и правой части массива, пока каждый
// элемент не окажется на своей позиции.

// Сложность	Наилучший случай	В среднем	Наихудший случай
// Время	        O(nlog)	          O(nlogn)	        O(nlogn)
// Память	        O(1)	          O(1)	        O(1)

using System;

namespace Algorithms
{
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            StartSort(array, 0, array.Length - 1);
            return array;
        }

        private static void StartSort(int[] array, int left, int right)
        {
            Random rnd = new Random();

            if (left < right)
            {
                int pivotIndex = rnd.Next(left, right);

                int newPivot = Partition(array, left, right, pivotIndex);

                StartSort(array, left, newPivot - 1);
                StartSort(array, newPivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right, int pivotIndex)
        {
            int pivotValue = array[pivotIndex];

            Manipulation<int>.Swap(array, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (array[i].CompareTo(pivotValue) < 0)
                {
                    Manipulation<int>.Swap(array, i, storeIndex);
                    storeIndex++;
                }
            }

            Manipulation<int>.Swap(array, storeIndex, right);

            return storeIndex;
        }
    }
}
