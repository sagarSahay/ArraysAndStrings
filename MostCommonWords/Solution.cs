using System;
using System.Text;

namespace MostCommonWords
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var separators = new[] {',', '.', '/'};
            var para = paragraph.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var countDict = new Dictionary<string, int>();
            var bannedDict = new HashSet<string>(banned);
            var count = 0;
            var result = "";
            foreach (var s in para)
            {
                var s1 = s.ToLowerInvariant().Trim();
                if (bannedDict.Contains(s1))
                {
                    continue;
                }

                if (string.IsNullOrEmpty(s1))
                {
                    continue;
                }

                if (countDict.ContainsKey(s1))
                {
                    countDict[s1] += 1;
                }
                else
                {
                    countDict.Add(s1, 1);
                }
                if (count < countDict[s1])
                {
                    count = countDict[s1];
                    result = s1;
                }
            }

            return result;
        }

        // public string MostCommonWord(string paragraph, string[] banned)
        // {
        //     var bannedSet = new HashSet<string>(banned);
        //     var answerFreqDict = new Dictionary<string, int>();
        //     var answerFrequency = 0;
        //     var result = "";
        //     var sb = new StringBuilder();
        //
        //     foreach (var c in paragraph.ToCharArray())
        //     {
        //         if (Char.IsLetter(c))
        //         {
        //             sb.Append(c);
        //         }
        //         if (sb.ToString().Trim().Length > 0)
        //         {
        //             var word = sb.ToString().ToLower();
        //             if (bannedSet.Contains(word) || string.IsNullOrEmpty(word))
        //             {
        //                 sb = new StringBuilder();
        //                 continue;
        //             }
        //
        //             if (answerFreqDict.ContainsKey(word))
        //             {
        //                 answerFreqDict[word] += 1;
        //             }
        //             else
        //             {
        //                 answerFreqDict.Add(word, 1);
        //             }
        //
        //             if (answerFreqDict[word] > answerFrequency)
        //             {
        //                 answerFrequency = answerFreqDict[word];
        //                 result = word;
        //             }
        //
        //             sb = new StringBuilder();
        //         }
        //     }
        //
        //     return result;
        // }
    }

    public static class StringHelper
    {
        public static string RemovePunctuation(this string s)
        {
            var charArray = s.ToCharArray();
            var sb = new StringBuilder();

            foreach (var c in charArray)
            {
                if (!Char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}