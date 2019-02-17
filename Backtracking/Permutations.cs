using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public class Permutations : IPermutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            BackTrack(nums, result, new List<int>());
            return result;
        }

        private static void BackTrack(IReadOnlyCollection<int> nums, ICollection<IList<int>> result, IList<int> tempResult)
        {
            if(tempResult.Count == nums.Count)
                result.Add(new List<int>(tempResult));

            foreach (var num in nums)
            {
                if(tempResult.Contains(num))
                    continue;
                tempResult.Add(num);
                BackTrack(nums, result, tempResult);
                tempResult.RemoveAt(tempResult.Count-1);
            }
        }
    }
}