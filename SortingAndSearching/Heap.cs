using System;
using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public abstract class Heap<T> : IHeap<T> where T : class, IComparable
    {        
        public int GetLeftChildIndex(int index)
        {
            if (index < 0)
                return -1;
            var leftChildIndex = 2 * index + 1;
            return leftChildIndex > CountOfElements ? -1 : leftChildIndex;
        }
        
        public int GetRightChildIndex(int index)
        {
            if (index < 0)
                return -1;
            var rightChildIndex = 2 * index + 2;
            return rightChildIndex > CountOfElements ? -1 : rightChildIndex;
        }

        public int GetParentIndex(int index)
        {
            if (index < 0 || index > CountOfElements)
                return -1;
            var parent = (index - 1) / 2;

            return parent < 0 ? -1 : parent;
        }

        public T GetHighestPriority()
        {
            return _heap.Count <= 0 ? null : _heap[0];
        }

        public T ElementAt(int index)
        {
            return index > CountOfElements || index < 0 ? null : _heap[index];
        }

        public T Remove()
        {
            var min = GetHighestPriority();
            _heap[0] = _heap[CountOfElements - 1];
            CountOfElements--;
            
            SiftDown(0);
            return min;
        }

        public void Add(T mergeNode)
        {
            _heap.Add(mergeNode);
            SiftUp(CountOfElements);
            CountOfElements++;
        }

        public void Swap(int index1, int index2)
        {
            var temp      = _heap[index1];
            _heap[index1] = _heap[index2];
            _heap[index2] = temp;
        }

        public Heap()
        {
            CountOfElements = 0;
            _heap = new List<T>();
        }

        public Heap(int countOfElements)
        {
            _heap = new List<T>();
            CountOfElements = countOfElements;
        }

        public abstract void SiftUp(int index);
        public abstract void SiftDown(int index);

        public int CountOfElements { get; private set; }
        private readonly IList<T> _heap;
    }
}