using System;
namespace Algorithms
{
    public static class Manipulation<T>
    {
        public static void Swap(T[] array, int left, int right)
        {
            if (left != right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }
    }
}
