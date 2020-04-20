namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i + 1;
        }
    }
}