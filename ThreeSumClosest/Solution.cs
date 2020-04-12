namespace ThreeSumClosest
{
    using System;

    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = nums[0] + nums[1] + nums[nums.Length - 1];
            Array.Sort(nums);

            for (int i = 0; i < nums.Length-2; i++)
            {
                var sum = target - nums[i];

                var low = i + 1;
                var high = nums.Length - 1;

                while (low < high)
                {
                    var current_sum = nums[i] + nums[low] + nums[high];
                    if (current_sum > sum)
                    {
                        high--;
                    }
                    else
                    {
                        low++;
                    }

                    if (Math.Abs(current_sum - target) < Math.Abs(result - target))
                    {
                        result = current_sum;
                    }
                }
            }

            return result;
        }
    }
}