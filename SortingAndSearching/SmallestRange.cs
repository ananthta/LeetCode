using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public class SmallestRanges : ISmallestRange
    {
        public int[] SmallestRange(IList<IList<int>> nums)
        {
            var minHeap = new MinHeap();
            var pointers = new int[nums.Count];

            for (var i = 0; i < nums.Count; i++)
            {
                
            }
            
            return new int[2];
        }

        private class MinHeap
        {
            public void Heapify()
            {
                //var endIndex = 
            }

            public int GetLeftChildIndex(int index)
            {
                if (index >= CountOfElements || index < 0)
                    return -1;

                var leftChildIndex = 2 * index + 1;

                return leftChildIndex >= CountOfElements ? -1 : leftChildIndex;
            }

            public int GetRightChildIndex(int index)
            {
                if (index >= CountOfElements || index < 0)
                    return -1;

                var rightChildIndex = 2 * index + 2;
                
                return rightChildIndex >= CountOfElements ? -1 : rightChildIndex;
            }

            public int GetParentIndex(int index)
            {
                if (index >= CountOfElements || index < 0)
                    return -1;

                var parentIndex = (index - 1) / 2;

                return parentIndex < 0 ? -1 : parentIndex;
            }

            public int CountOfElements { get; set; }
            private readonly IList<int> _heap = new List<int>();
        }
    }
}