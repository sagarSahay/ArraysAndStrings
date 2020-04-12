using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            var dict = new Dictionary<string , List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var strChars = strs[i].ToCharArray();
                Array.Sort(strChars);
                var str = new string(strChars);
                if (dict.ContainsKey(str))
                {
                    dict[str].Add(strs[i]);
                }
                else
                {
                    var ls =new List<string>(){strs[i]};
                    dict.Add(str, ls);
                }
            }
            
            var res = new List<IList<string>>();

            foreach (var keyVal in dict)
            {
                res.Add(dict[keyVal.Key]);
            }

            return res;
        }
    }
}