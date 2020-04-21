using System;

namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var nums1_copy = new int[m];
            Array.Copy(nums1, 0, nums1_copy, 0, m);

            var p1 = 0;
            var p2 = 0;

            var p = 0;

            while (p1 < m && p2 < n)
            {
                if (nums1_copy[p1] > nums2[p2])
                {
                    nums1[p] = nums2[p2];
                    p2++;
                }
                else
                {
                    nums1[p] = nums1_copy[p1];
                    p1++;
                }

                p++;
            }

            if (p1 < m)
            {
                Array.Copy(nums1_copy, p1, nums1, p1 + p2, m + n - p1 - p2);
            }

            if (p2 < n)
            {
                Array.Copy(nums2, p2, nums1, p1 + p2, m + n - p1 - p2);
            }
        }
    }
}