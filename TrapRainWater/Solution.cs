using System;

namespace TrapRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0)
            {
                return 0;
            }
            var count = height.Length;
            var lmax = new int[count];
            var rmax = new int[count];
            var res = 0;

            lmax[0] = height[0];
            rmax[count - 1] = height[count - 1];

            for (int i = 1; i < height.Length; i++)
            {
                lmax[i] = Math.Max(lmax[i - 1], height[i]);
            }

            for (int i = count - 2; i >= 0; i--)
            {
                rmax[i] = Math.Max(rmax[i + 1], height[i]);
            }

            for (int i = 0; i < count; i++)
            {
                res += Math.Min(lmax[i], rmax[i]) - height[i];
            }

            return res;
        }
    }
}