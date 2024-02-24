using System;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            int N;
            Console.Write("Введите количество элементов N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[] inputArray = new int[N];

            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                inputArray[i] = rand.Next(50);
            }

            Console.WriteLine("Неотсортированный массив: ");
            foreach (int i in inputArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine("Отсортированный массив: ");
            foreach (int i in sortedArray) 
            {
                Console.Write($"{i} ");
            }
        }

        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);

            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
        {
            int pivotIndex = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivotIndex++;
                    Swap(ref array[pivotIndex], ref array[i]);
                }
            }

            pivotIndex++;
            Swap(ref array[pivotIndex], ref array[maxIndex]);

            return pivotIndex;
        }

        private static void Swap(ref int leftItem, ref int rightItem)
        {
            int temp = leftItem;

            leftItem = rightItem;

            rightItem = temp;
        }
    }
}