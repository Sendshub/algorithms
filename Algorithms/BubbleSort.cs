// Алгоритм сортировки пузырьком – это простой алгоритм сортировки, который, выполняя проходы
// по массиву элементов, каждый раз перемещает наибольший элемент в его конец.

// Сложность	Наилучший случай	В среднем	Наихудший случай
// Время	        O(n)	          O(n2)	        O(n2)
// Память	        O(1)	          O(1)	        O(1)

using System;
namespace Algorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("Bubble sorting");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Manipulation<int>.Swap(array, j, j + 1);
                    }
                }
            }

            return array;
        }

        public static int[] DescendingSort(int[] array)
        {
            Console.WriteLine("Bubble sorting");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Manipulation<int>.Swap(array, j, j + 1);
                    }
                }
            }

            return array;
        }
    }
}
