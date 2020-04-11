namespace LengthOfLongestSubstring
{
    using System;
    using System.Collections.Generic;
    using System.IO.Pipes;
    using System.Text;

    public class Solution
    {
        // public int LengthOfLongestSubstring(string input)
        // {
        //     var res = 0;
        //     var n = input.Length;
        //
        //     for (int i = 0; i < n; i++)
        //     {
        //         for (int j = i + 1; j <= n; j++)
        //         {
        //             if (allUniqueChars(input, i, j))
        //             {
        //                 res =  Math.Max(res, j - i);
        //             }
        //         }
        //     }
        //
        //     return res;
        // }

        public int LengthOfLongestSubstring(string input)
        {
            var count = input.Length;

            var left = 0;
            var right = 0;

            var res = 0;
            
            var mapDict = new HashSet<char>();

            while (left < count && right < count)
            {
                if (!mapDict.Contains(input[right]))
                {
                    mapDict.Add(input[right]);
                    right++;
                    res = Math.Max(res, right - left);
                }
                else
                {
                    mapDict.Remove(input[left]);
                    left++;
                }
            }

            return res;
        }
        private bool allUniqueChars(string input, in int i, in int j)
        {
            var set = new HashSet<char>();
            for (int k = i; k < j; k++)
            {
                if (!set.Contains(input[k]))
                {
                    set.Add(input[k]);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}