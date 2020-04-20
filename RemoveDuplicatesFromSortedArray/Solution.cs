namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {

            var left = 0;
            var right = 1;
            var length = nums.Length;

            while (left < length && right < length)
            {
                if (nums[left] == nums[right])
                {
                    right++;
                }
            }

        }
    }
}