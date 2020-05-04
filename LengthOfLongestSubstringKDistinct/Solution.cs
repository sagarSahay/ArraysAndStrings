namespace LengthOfLongestSubstringKDistinct
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            var left = 0 ;
            var right = 0;
            var len = s.Length;
            var maxLen = 1;
            var charDict = new Dictionary<char, int>();
        
            if(string.IsNullOrEmpty(s)){
                return 0;
            }
            if(k == 0){
                return 0;
            }
        
            while(right < len){
                if(charDict.ContainsKey(s[right])){
                    charDict[s[right]] = right;
                }else{
                    charDict.Add(s[right], right);
                }
                right++;
                if(charDict.Count() == k+1){
                    var minKeyValue = charDict.OrderBy(x=> x.Value).FirstOrDefault();
                    left = minKeyValue.Value +1;
                    charDict.Remove(minKeyValue.Key);
                }
            
                maxLen = Math.Max(maxLen, right-left);
            }
            return maxLen;
        }
    }
}