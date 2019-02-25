using LeetCode.Models;

namespace LeetCode.SortingAndSearching
{
    public class MinHeap : Heap<MergeNode>
    {
        public override void SiftUp(int index)
        {
            var parentIndex = GetParentIndex(index);
            if (parentIndex <= 0 || ElementAt(parentIndex).Value <= ElementAt(index).Value) return;
            Swap(parentIndex, index);
            SiftUp(parentIndex);
        }

        public override void SiftDown(int index)
        {
            var leftChildIndex = GetLeftChildIndex(index);
            var rightChildIndex = GetRightChildIndex(index);

            var smallerIndex = -1;
            if (leftChildIndex > 0 && rightChildIndex > 0)
            {
                smallerIndex = ElementAt(leftChildIndex).CompareTo(ElementAt(rightChildIndex)) < 0 ? leftChildIndex : index;
            }
            else if(leftChildIndex > 0)
            {
                smallerIndex = leftChildIndex;
            }
            else if(rightChildIndex > 0)
            {
                smallerIndex = rightChildIndex;
            }
            
            if(smallerIndex == -1)
                return;

            if (ElementAt(smallerIndex).CompareTo(ElementAt(index)) >= 0) return;
            Swap(smallerIndex, index);
            SiftDown(smallerIndex);
        }
    }
}