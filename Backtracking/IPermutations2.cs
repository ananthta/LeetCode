using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public interface IPermutations2
    {
        IEnumerable<IList<int>> PermuteUnique(int[] nums);
    }
}