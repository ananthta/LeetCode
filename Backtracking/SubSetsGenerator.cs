using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Backtracking
{
    public class SubSetsGenerator : ISubSetsGenerator
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            BackTrack(result, nums, 0, new List<int>());
            return result;
        }

        private static void BackTrack(ICollection<IList<int>> result, IReadOnlyCollection<int> nums, int pos,
            IList<int> tempList)
        {
            if (nums.Count == pos)
            {
                result.Add(new List<int>(tempList));
                return;
            }
 
            tempList.Add(nums.ElementAt(pos));
            BackTrack(result, nums, pos+1, tempList);
            tempList.RemoveAt(tempList.Count-1);
            BackTrack(result, nums, pos+1, tempList);
        }
    }
}