using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) 
        {
            var numsDict = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (numsDict.ContainsKey(complement))
                {
                    return new[] {i, numsDict[complement]};
                }

                if (!numsDict.ContainsKey(nums[i]))
                {
                    numsDict.Add(nums[i],i);
                }
               
            }

            return null;
        }
    }
}