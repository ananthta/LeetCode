using System.Collections.Generic;

namespace LeetCode.SortingAndSearching
{
    public class RotatedSortedArray : IRotatedSortedArray
    {
        public int Search(int[] nums, int target)
         {
            var pivot = GetPivotIndex(0, nums.Length - 1, nums);
            if (pivot == -1)
                return BinarySearch(0, nums.Length - 1, target, nums);

            if (nums[pivot] == target)
                return pivot;

            return target < nums[0]
                ? BinarySearch(pivot + 1, nums.Length - 1, target, nums)
                : BinarySearch(0, pivot - 1, target, nums);
        }

        private static int GetPivotIndex(int startIndex, int endIndex, IReadOnlyList<int> nums)
        {
            if (startIndex > endIndex)
                return -1;

            var mid = (startIndex + endIndex) / 2;

            if (mid < endIndex && nums[mid] > nums[mid + 1])
                return mid;

            if (mid > startIndex && nums[mid] < nums[mid - 1])
                return mid - 1;

            return nums[startIndex] >= nums[mid]
                ? GetPivotIndex(startIndex, mid - 1, nums)
                : GetPivotIndex(mid + 1, endIndex, nums);
        }

        private static int BinarySearch(int startIndex, int endIndex, int target, IReadOnlyList<int> nums)
        {
            if (startIndex > endIndex)
                return -1;

            var mid = (startIndex + endIndex) / 2;

            if (nums[mid] == target)
                return mid;

            return target < nums[mid]
                ? BinarySearch(startIndex, mid - 1, target, nums)
                : BinarySearch(mid + 1, endIndex, target, nums);
        }
    }
}