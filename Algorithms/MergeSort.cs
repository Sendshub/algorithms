// Сортировка слиянием – алгоритм сортировки, который упорядочивает массив в определённом
// порядке. Реализует принцип «разделяй и властвуй», сначала массив разбивается на части, после
// чего каждая часть сортируется отдельно и объединяется в общее решение.
// Этапы сортировки:
// 1. Массив разбивается на два подмассива примерно одинакового размера. Рекурсивное
// разбиение массива на подмассивы происходит до тех пор, пока размер подмассива не
// достигнет единицы (любой массив длины 1 можно считать упорядоченным).
// 2. Каждая из частей сортируется отдельно.
// 3. Два упорядоченных подмассива соединяются в один.

// Сложность	Наилучший случай	В среднем	Наихудший случай
// Время	        O(nlogn)	     O(nlogn)	   O(nlogn)
// Память	        O(n)	          O(n)	        O(n)

using System;
namespace Algorithms
{
    public static class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            StartSort(array);
            return array;
        }

        private static void StartSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];

            Array.Copy(array, 0, left, 0, leftSize);
            Array.Copy(array, leftSize, right, 0, rightSize);

            StartSort(left);
            StartSort(right);

            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int totalLength = left.Length + right.Length;

            while (totalLength > 0)
            {
                if(leftIndex >= left.Length)
                {
                    array[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    array[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    array[targetIndex] = left[leftIndex++];
                }
                else
                {
                    array[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                totalLength--;
            }
        }
    }
}