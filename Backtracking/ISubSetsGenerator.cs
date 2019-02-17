using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public interface ISubSetsGenerator
    {
        IList<IList<int>> Subsets(int[] nums);
    }
}