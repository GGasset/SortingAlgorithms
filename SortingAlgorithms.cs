using System.Collections.Generic;

namespace SortingAlgorithms
{
    internal class SortingAlgorithms
    {
        public static List<int> SelectionSort(List<int> toSort)
        {
            List<int> output = new List<int>();
            int initialLength = toSort.Count;
            for (int i = 0; i < initialLength; i++)
            {
                int minValueIndex = GetIndexWithLowestValue(toSort);
                output.Add(toSort[minValueIndex]);
                toSort.RemoveAt(minValueIndex);
            }
            return output;
        }

        public static List<int> QuickSort(List<int> toSort)
        {
            List<int> output = new List<int>(), lowerValues = new List<int>(), higherValues = new List<int>();
            int pivotIndex = toSort.Count / 2 - 1;

            if (toSort.Count > 2)
            {
                for (int i = 0; i < toSort.Count; i++)
                    if (toSort[i] >= toSort[pivotIndex])
                        higherValues.Add(toSort[i]);
                    else
                        lowerValues.Add(toSort[i]);

                QuickSort(lowerValues);
                QuickSort(higherValues);

                output = lowerValues;
                foreach (int value in higherValues)
                    output.Add(value);
            }
            else 
            {
                if (toSort[0] > toSort[1])
                {
                    int higherValueMemory = toSort[1];
                    toSort[1] = toSort[0];
                    toSort[0] = higherValueMemory;
                }
                output = toSort;
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