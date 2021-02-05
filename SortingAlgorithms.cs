using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class SortingAlgorithms
    {
        public static List<int> SelectionSort(List<int> toSort)
        {
            int initialLength = toSort.Count;
            List<int> output = new List<int>();
            for (int i = 0; i < initialLength; i++)
            {
                int minValueIndex = GetIndexWithLowestValue(toSort);
                output.Add(toSort[minValueIndex]);
                toSort.RemoveAt(minValueIndex);
            }
            return output;
        }

        private static int GetIndexWithLowestValue(List<int> list)
        {
            int lowestValue = int.MaxValue, lowestIndex = -1;
            for (int i = 0; i < list.Count; i++)
                if (list[i] < lowestValue)
                    lowestValue = list[lowestIndex = i];
            return lowestIndex;
        }
    }
}
