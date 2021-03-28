// Сортировка выбором – алгоритм сортировки, который на каждом своем шаге отыскивает
// наименьший элемент в неотсортированной части массива и устанавливает его в соответствующую
// позицию массива.

// Сложность	Наилучший случай	В среднем	Наихудший случай
// Время	        O(n)	          O(n2)	        O(n2)
// Память	        O(1)	          O(1)	        O(1)

using System;
namespace Algorithms
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < array.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(array, sortedRangeEnd);
                Manipulation<int>.Swap(array, sortedRangeEnd, nextIndex);
                sortedRangeEnd ++;
            }
            
            return array;
        }

        private static int FindIndexOfSmallestFromIndex(int[] array, int sortedRangeEnd)
        {
            int currentSmallest = array[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < array.Length; i++)
            {
                if (currentSmallest.CompareTo(array[i]) > 0)
                {
                    currentSmallest = array[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }
    }
}