// Алгоритм сортировки вставками – это простой алгоритм, на каждом шаге которого выбирается один
// из элементов массива, для которого осуществляется поиск нужной позиции в отсортированном
// массиве. Алгоритм выполняется до тех пор, пока набор входных данных не будет исчерпан. Выбор
// очередного элемента из исходного осуществляется произвольно.

// Сложность	Наилучший случай	В среднем	Наихудший случай
// Время	        O(n)	          O(n2)	        O(n2)
// Память	        O(1)	          O(1)	        O(1)

using System;
namespace Algorithms
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < array.Length)
            {
                if (array[sortedRangeEndIndex].CompareTo(array[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(array, array[sortedRangeEndIndex]);
                    Insert(array, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }

            return array;
        }

        private static int FindInsertionIndex(int[] array, int valueToInsert)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }

            throw new InvalidOperationException("Index is not found!");
        }

        private static void Insert(int[] array, int indexInsertingAt, int indexInsertingFrom)
        {
            int temp = array[indexInsertingAt];
            array[indexInsertingAt] = array[indexInsertingFrom];

            for (int i = indexInsertingFrom; i > indexInsertingAt; i--)
            {
                array[i] = array[i - 1];
            }

            array[indexInsertingAt + 1] = temp;
        }
    }
}