using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public interface ICombinationSum
    {
        IList<IList<int>> Find(int[] nums);
    }
}