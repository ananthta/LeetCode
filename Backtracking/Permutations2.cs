using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Backtracking
{
    public class Permutations2 : IPermutations2
    {
        public IEnumerable<IList<int>> PermuteUnique(int[] nums)
        {
            var isVisited = new bool[nums.Length];
            var result = new List<IList<int>>();
            BackTrack(nums, result, new List<int>(), isVisited);
            return result;
        }

        private static void BackTrack(IReadOnlyCollection<int> nums, ICollection<IList<int>> result,
            IList<int> tempResult, IList<bool> isVisited)
        {
            if (nums.Count == tempResult.Count)
            {
                result.Add(new List<int>(tempResult));
                return;
            }

            for (var i = 0; i < nums.Count; i++)
            {
                if(isVisited[i] || i > 0 && nums.ElementAt(i) == nums.ElementAt(i-1) && !isVisited[i-1])
                    continue;
                
                tempResult.Add(nums.ElementAt(i));
                isVisited[i] = true;
                BackTrack(nums, result, tempResult, isVisited);
                tempResult.RemoveAt(tempResult.Count-1);
                isVisited[i] = false;
            }
        }
    }
}