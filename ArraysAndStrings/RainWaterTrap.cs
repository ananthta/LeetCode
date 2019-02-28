using System;

namespace LeetCode.ArraysAndStrings
{
    public class RainWaterTrap : IRainWaterTrap
    {
        public int Trap(int[] height)
        {
            var leftMaxHeight = 0;
            var rightMaxHeight = 0;
            var leftPointer = 0;
            var rightPointer = height.Length - 1;
            var waterQuantity = 0;

            while (leftPointer < rightPointer)
            {
                leftMaxHeight = Math.Max(leftMaxHeight, height[leftPointer]);
                rightMaxHeight = Math.Max(rightMaxHeight, height[rightPointer]);

                if (leftMaxHeight < rightMaxHeight)
                {
                    waterQuantity += leftMaxHeight-height[leftPointer];
                    leftPointer++;
                }
                else
                {
                    waterQuantity += rightMaxHeight-height[rightPointer];
                    rightPointer--;
                }
            }

            return waterQuantity;
        }
    }
}