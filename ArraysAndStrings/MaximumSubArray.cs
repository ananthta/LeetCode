using System;
using System.Collections.Generic;

namespace LeetCode.ArraysAndStrings
{
    public class MaximumSubArray : IMaximumSubArray
    {
        public int MaxSubArrayLen(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            var sum = 0;
            var lengthOfMaxSubArray = 0;
            var sumToIndexDictionary = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum == k)
                    lengthOfMaxSubArray = i + 1;
                else if(sumToIndexDictionary.ContainsKey(sum-k))
                {
                    lengthOfMaxSubArray = Math.Max(lengthOfMaxSubArray, i - sumToIndexDictionary[sum-k]);
                }
                
                if(!sumToIndexDictionary.ContainsKey(sum))
                    sumToIndexDictionary.Add(sum, i);
            }

            return lengthOfMaxSubArray;
        }
    }
}