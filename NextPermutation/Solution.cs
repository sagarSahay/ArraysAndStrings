namespace NextPermutation
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            var i = nums.Length - 2;
            while (i > 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }

            if (i >= 0)
            {
                var j = nums.Length - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }

                swap(nums, i, j);
            }
            reverse(nums, i + 1);
        }

        private void reverse(int[] nums, int i)
        {
            var j = nums.Length - 1;
            while (j>=i)
            {
                swap(nums, i,j);
                i++;
                j--;
            }
        }

        private void swap(int[] nums, in int i, in int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}