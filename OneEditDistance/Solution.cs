using System;

namespace OneEditDistance
{
    public class Solution
    {
        public bool IsOneEditDistance(string s, string t)
        {
            var sLen = s.Length;
            var tLen = t.Length;

            if (Math.Abs(sLen - tLen) > 1 || s == t)
            {
                return false;
            }

            var si = 0;
            var ti = 0;
            var count = 1;

            while (si < sLen && ti < tLen)
            {
                if (s[si] != t[ti])
                {
                    count -= 1;
                    if (count < 0)
                    {
                        return false;
                    }
                    if (sLen > tLen)
                    {
                        si++;
                    }
                    else if (tLen > sLen)
                    {
                        ti++;
                    }
                    else
                    {
                        si++;
                        ti++;
                    }
                }
                else
                {
                    si++;
                    ti++;
                }
            }

            return true;
        }
    }
}