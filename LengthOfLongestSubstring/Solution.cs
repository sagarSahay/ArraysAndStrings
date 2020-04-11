namespace LengthOfLongestSubstring
{
    using System;
    using System.Collections.Generic;
    using System.IO.Pipes;
    using System.Text;

    public class Solution
    {
        public int LengthOfLongestSubstring(string input)
        {
            var res = 0;
            var n = input.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (allUniqueChars(input, i, j))
                    {
                        res =  Math.Max(res, j - i);
                        return res;
                    }
                }
            }

            return 0;
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