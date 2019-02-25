using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public  class HeapSrt
    {
        public int GetParent(int index, int endIndex)
        {
            if (index < 0 || index < endIndex)
                return -1;

            return (index - 1) / 2;
        }

        public int GetLeftChildIndex(int parentIndex, int endIndex)
        {
            if (parentIndex < 0)
                return -1;

            var result = 2 * parentIndex + 1;

            return result > endIndex ? -1 : result;
        }

        public int GetRightChildIndex(int parentIndex, int endIndex)
        {
            if (parentIndex < 0)
                return -1;

            var result = 2 * parentIndex + 2;

            return result > endIndex ? -1 : result;
        }

        public void Swap(int index1, int index2)
        {
            var temp      = _heap[index1];
            _heap[index1] = _heap[index2];
            _heap[index2] = temp;
        }

        public void PercolateDown(int index, int endIndex)
        {
            var leftChildIndex = GetLeftChildIndex(index, endIndex);
            var rightChildIndex = GetRightChildIndex(index, endIndex);

            if (leftChildIndex != -1 && _heap[leftChildIndex] > _heap[index])
            {
                Swap(index, leftChildIndex);
                PercolateDown(leftChildIndex, endIndex);
            }

            if (rightChildIndex == -1 || _heap[rightChildIndex] <= _heap[index]) return;
            Swap(index, rightChildIndex);
            PercolateDown(rightChildIndex, endIndex);
        }

        public void Heapify(int endIndex)
        {
            var parentIndex = GetParent(endIndex, endIndex);
            while (parentIndex >= 0)
            {
                PercolateDown(parentIndex, endIndex);
                parentIndex--;
            }
        }

        public void HeapSort()
        {
            Heapify(_heap.Count-1);
            var endIndex = _heap.Count - 1;
            while (endIndex > 0)
            {
                Swap(0, endIndex);
                endIndex--;
                PercolateDown(0, endIndex);
            }
        }

        public HeapSrt(IList<int> input)
        {
            _heap = input;
        }

        private readonly IList<int> _heap;
    }
}