using System;
namespace Algorithms
{
    public static class Manipulation<T>
    {
        public static void Swap(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
