namespace LeetCode.SortingAndSearching
{
    public class RotatedSortedArray2 : IRotatedSortedArray2
    {
        public bool Search(int[] nums, int target)
        {
            var startIndex = 0;
            var endIndex = nums.Length - 1;

            while (startIndex <= endIndex)
            {
                var mid = (startIndex + endIndex) / 2;
                
                if (nums[mid] == target)
                    return true;
                
                if (nums[mid] > nums[startIndex])
                {
                    if (target < nums[startIndex] && target >= nums[startIndex])
                    {
                        endIndex = mid - 1;
                    }
                    else
                    {
                        startIndex = mid + 1;
                    }
                }
                else if(nums[mid] < nums[startIndex])
                {
                    if (target > nums[mid] && target < nums[startIndex])
                    {
                        startIndex = mid + 1;
                    }
                    else
                    {
                        endIndex = mid - 1;
                    }
                }
                else
                {
                    startIndex++;
                }
            }

            return false;
        }
    }
}