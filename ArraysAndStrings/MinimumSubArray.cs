using System;

namespace LeetCode.ArraysAndStrings
{
    public class MinimumSubArray : IMinimumSubArray
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                return 0;

            var j = 0;
            var sum = 0;
            var minSubArrayLength = int.MaxValue;
            
            for (var i = 0; i < nums.Length;)
            {
                sum += nums[i++];

                if (sum < s)
                    continue;

                while (sum >= s)
                {
                    minSubArrayLength = Math.Min(minSubArrayLength, i - j);
                    sum -= nums[j++];
                }
            }

            return minSubArrayLength == int.MaxValue ? 0 : minSubArrayLength;
        }
    }
}