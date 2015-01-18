using System;

namespace Redux.Tests
{
    // The test is really "does this compile".
    class Quicksort
    {
        // From Wikipedia;
        public static void QuickSort<T>(Array<T> array, Index<T> fromInclusive, Index<T> toInclusive)
            where T : IComparable<T>
        {
            if (fromInclusive < toInclusive)
            {
                var p = Partition(array, fromInclusive, toInclusive);
                QuickSort(array, fromInclusive, p.Previous());
                QuickSort(array, p.Next(), toInclusive);
            }
        }

        private static Index<T> Partition<T>(Array<T> array, Index<T> fromInclusive, Index<T> toInclusive)
            where T : IComparable<T>
        {
            // lo is the index of the leftmost element of the subarray
            // hi is the index of the rightmost element of the subarray (inclusive)
            var pivotIndex = ChoosePivot(array, fromInclusive, toInclusive);
            var pivotValue = array[pivotIndex];
            // put the chosen pivot at A[toInclusive]
            Swap(array, pivotIndex, toInclusive);

            var storedIndex = fromInclusive;
            // Compare remaining array elements against pivotValue = A[hi]
            for (var i = fromInclusive; i < toInclusive; i = i.Next())
            {
                if (array[i].CompareTo(pivotValue) < 0)
                {
                    Swap(array, i, storedIndex);
                    storedIndex = storedIndex.Next();
                }
            }

            Swap(array, storedIndex, toInclusive); // Move pivot to its final place
            return storedIndex;
        }

        private static Index<T> ChoosePivot<T>(Array<T> array, Index<T> fromInclusive, Index<T> toInclusive)
        {
            return fromInclusive + (toInclusive - fromInclusive) / 2;
        }

        private static void Swap<T>(Array<T> array, Index<T> x, Index<T> y)
        {
            var tmp = array[x];
            array[x] = array[y];
            array[y] = tmp;
        }
    }
}
