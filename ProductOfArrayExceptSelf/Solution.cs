namespace ProductOfArrayExceptSelf
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var l = new int[nums.Length];
            l[0] = 1;

            var r = new int[nums.Length];
            r[nums.Length - 1] = 1;

            var answer = new int[nums.Length];

            for (int i = 1; i < nums.Length; i++)
            {
                l[i] = nums[i - 1] * l[i - 1];
            }

            for (int i = nums.Length-2; i >=0; i--)
            {
                r[i] = nums[i + 1] * r[i + 1];
            }

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = l[i] * r[i];
            }


            return answer;


        }
    }
}