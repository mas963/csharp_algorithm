using System;
using System.Collections.Generic;

namespace QuickSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sayilar = new List<double>();
            sayilar.Add(12);
            sayilar.Add(42);
            sayilar.Add(89);
            sayilar.Add(32);
            sayilar.Add(44);
            sayilar.Add(23);

            int n = sayilar.Count;

            QuickSort(sayilar, 0, n-1);
        }

        static int QuickPartition(List<double> arr, int low, int high)
        {
            double pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            double temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        static void QuickSort(List<double> arr, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickPartition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
            Console.WriteLine(arr);
        }
    }
}
