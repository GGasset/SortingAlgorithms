using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main()
        {
            List<int> toSort = new List<int>(new int[] { 46, 71, 89, 5 });
            List<int> sorted = SortingAlgorithms.QuickSort(toSort);
            foreach (int item in sorted)
                Console.Write(item + " ");
            Console.ReadKey(true);
        }
    }
}
