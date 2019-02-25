using System;

namespace LeetCode.Models
{
    public class MergeNode : IComparable
    {
        public int Value { get; private set; }
        public int StreamId { get; private set; }

        public MergeNode(int value, int streamId)
        {
            Value = value;
            StreamId = streamId;
        }

        public int CompareTo(MergeNode other)
        {
            return Value.CompareTo(other.Value);
        }

        public int CompareTo(object obj)
        {
            var otherMergeNode = (MergeNode) obj;

            return otherMergeNode.Value.CompareTo(Value);
        }
    }
}