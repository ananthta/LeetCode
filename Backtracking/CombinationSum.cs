using System.Linq;
using System.Collections.Generic;

namespace LeetCode.Backtracking
{
    public class CombinationSum : ICombinationSum
    {
        public IList<IList<int>> Find(int[] nums)
        {
            var result = new List<IList<int>>();
            BacTrack(nums, 0, result, new List<int>(), 7);
            return result;
        }

        private static void BacTrack(IReadOnlyCollection<int> nums, int position, ICollection<IList<int>> result,
            IList<int> tempResult, int remainingSum)
        {
            if (remainingSum < 0)
                return;
            if (remainingSum == 0)
            {
                result.Add(new List<int>(tempResult));
            }
            else
            {
                for (var i = position; i < nums.Count; i++)
                {
                    tempResult.Add(nums.ElementAt(i));
                    BacTrack(nums, i, result, tempResult, remainingSum-nums.ElementAt(i));
                    tempResult.RemoveAt(tempResult.Count-1);
                }
            }
        }
    }
}