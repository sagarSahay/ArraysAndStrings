namespace MostCommonWords
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var para = paragraph.Split(' ');
            var countDict = new Dictionary<string, int>();
            foreach (var s in para)
            {
                foreach (var bannedString in banned)
                {
                    if (s.ToLower() != bannedString.ToLower())
                    {
                        if (countDict.ContainsKey(s.ToLower()))
                        {
                            countDict[s.ToLower()] += 1;
                        }
                        else
                        {
                            countDict.Add(s.ToLower(), 1);
                        }
                    }
                }
                
            }
            return countDict.OrderByDescending(x => x.Value).First().Key;
        }
    }
}