using System;
using System.Collections.Generic;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main()
        {
            List<int> toSort = new List<int>(new int[] { 3, 1, 6, 9, 46, 91, 64, 79 });
            List<int> sorted = SortingAlgorithms.SelectionSort(toSort);
            foreach (int item in sorted)
                Console.Write(item + " ");
            Console.ReadKey(true);
        }
    }
}
