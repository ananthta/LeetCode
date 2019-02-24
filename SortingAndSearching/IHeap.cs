using System;

namespace LeetCode.SortingAndSearching
{
    public interface IHeap<T> where T : IComparable
    {
        T Remove();
        void Add(T mergeNode);
        void SiftUp(int index);
        T ElementAt(int index);
        T GetHighestPriority();
        void SiftDown(int index);
        int GetParentIndex(int index);
        int GetLeftChildIndex(int index);
        void Swap(int index1, int index2);
        int GetRightChildIndex(int index);

        
        int CountOfElements { get; }
    }
}