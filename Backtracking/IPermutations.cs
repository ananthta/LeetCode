using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public interface IPermutations
    {
        IList<IList<int>> Permute(int[] nums);
    }
}