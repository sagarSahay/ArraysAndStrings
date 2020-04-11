using System;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            // for (int i = 0; i < height.Length; i++)
            // {
            //     for (int j = i+1; j < height.Length; j++)
            //     {
            //         var min = Math.Min(height[i], height[j]);
            //         max = Math.Max(max, min * (j - i));
            //     }
            // }
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    max = Math.Max(max, height[left] * (right - left));
                    left++;
                }
                else
                {
                    max = Math.Max(max, height[right] * (right - left));
                    right--;
                }
            }

            return max;
        }
    }
}