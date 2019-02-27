using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.ArraysAndStrings
{
    public class Sum3 : ISum3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
                return result.ToList();

            Array.Sort(nums);

            for (var i = 0; i + 2 < nums.Length; i++)
            {
                
                if (i > 0 && nums[i] == nums[i - 1]) 
                    continue;
                    
                var j = i + 1;
                var k = nums.Length - 1;

                var target = -nums[i];
                while (j < k)
                {
                    var sum = nums[j] + nums[k];
                    if (sum == target)
                    {
                        result.Add(new List<int>{nums[i], nums[j] ,nums[k]});
                        
                        j++;
                        k--;

                        while (j < k && nums[j] == nums[j - 1]) j++;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if (sum > target)
                        k--;
                    else
                        j++;
                }
            }

            return result;
        }
    }
}