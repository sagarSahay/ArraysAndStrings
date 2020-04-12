using System.Collections.Generic;
using System.Linq;

namespace MinimumWindowSubstring
{
    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            var dictT = new Dictionary<char, int>();
            var resultLength = int.MaxValue;
            var result = "";
            foreach (var c in t.ToCharArray())
            {
                var count = dictT.GetValueOrDefault(c, 0);
                dictT[c] = 1 + count;
            }

            var required = dictT.Count;

            var formed = 0;
            var right = 0;
            var left = 0;

            var windowsDict = new Dictionary<char, int>();

            while (right < s.Length)
            {
                var count = windowsDict.GetValueOrDefault(s[right], 0);
                windowsDict[s[right]] = count + 1;

                if (dictT.ContainsKey(s[right]) && dictT[s[right]] == windowsDict[s[right]])
                {
                    formed++;
                }

                while (left < right && formed == required)
                {
                    if (resultLength > right - left + 1)
                    {
                        resultLength = right - left + 1;
                        result = s.Substring(left, right - left + 1);
                    }

                    windowsDict[s[left]] = 1-windowsDict[s[left]];

                    if (dictT.ContainsKey(s[left]) && windowsDict[s[left]] < dictT[s[left]])
                    {
                        formed--;
                    }

                    left++;
                }

                right++;
            }
            // var result = "";
            // var minLength = int.MaxValue;
            //
            // var left = 0;
            // var count = 0;
            // var charCountDict = new Dictionary<char, int>();
            // foreach (var c in t.ToCharArray())
            // {
            //     if (charCountDict.ContainsKey(c))
            //     {
            //         charCountDict[c]++;
            //     }
            //     else
            //     {
            //         charCountDict.Add(c, 1);
            //     }
            // }
            // for (int right = 0; right < s.Length; right++)
            // {
            //     if (charCountDict.ContainsKey(s[right]))
            //     {
            //         charCountDict[s[right]] = charCountDict[s[right]] - 1;
            //         if (charCountDict[s[right]] >= 0)
            //         {
            //             count++;
            //         }
            //     }
            //
            //     while (count == t.Length)
            //     {
            //         if (minLength > right - left + 1)
            //         {
            //             minLength = right - left + 1;
            //             result = s.Substring(left, right - left);
            //         }
            //
            //         if (charCountDict.ContainsKey(s[right]))
            //         {
            //             charCountDict[s[right]] = charCountDict[s[right]] + 1;
            //             if (charCountDict[s[right]] > 0)
            //             {
            //                 --count;
            //             }
            //         }
            //
            //         ++left;
            //     }
            // }
            // var resultLength = int.MaxValue;
            // var targetSet = new HashSet<char>(t.ToCharArray());
            //
            // var left = 0;
            // var right = s.Length;
            //
            // while (right < s.Length)
            // {
            //     if (targetSet.Contains(s[right]))
            //     {
            //         var res = s.Substring(left,)
            //     }
            //     else
            //     {
            //         right++;
            //     }
            // }

            // for (int i = 0; i < s.Length; i++)
            // {
            //     var low = i;
            //     var high = s.Length - 1;
            //     if (!targetSet.Contains(s[i]))
            //     {
            //         continue;
            //     }
            //
            //     var visitedSet = new HashSet<(char, bool)>();
            //
            //     while (low <= high)
            //     {
            //         if (targetSet.Contains(s[low]))
            //         {
            //             if (!visitedSet.Contains((s[low], true)))
            //             {
            //                 visitedSet.Add((s[low], true));
            //             }
            //
            //             if (visitedSet.Count == t.Length)
            //             {
            //                 var res = s.Substring(i, low - i + 1);
            //                 if (res.Length < resultLength)
            //                 {
            //                     resultLength = res.Length;
            //                     result = res;
            //                 }
            //             }
            //         }
            //
            //         low++;
            //     }
            // }


            return result;
        }
    }
}