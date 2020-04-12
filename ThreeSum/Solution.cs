using System.Collections.Generic;
using System.Linq;

namespace ThreeSum
{
    using System;

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i + 1]))
                {
                    var complement = 0 - nums[i];

                    var low = i + 1;
                    var high = nums.Length - 1;

                    while (low < high)
                    {
                        if (nums[low] + nums[high] == complement)
                        {
                            var res = new List<int>();
                            res.Add(nums[i]);
                            res.Add(nums[low]);
                            res.Add(nums[high]);
                            result.Add(res);
                            while (low < high && nums[low] == nums[low + 1])
                            {
                                low++;
                            }

                            while (low < high && nums[high] == nums[high - 1])
                            {
                                high--;
                            }

                            low++;
                            high--;
                        }
                        else if (nums[low] + nums[high] > complement)
                        {
                            high--;
                        }
                        else
                        {
                            low++;
                        }
                    }
                }
            }

            return result;
        }
    }
}