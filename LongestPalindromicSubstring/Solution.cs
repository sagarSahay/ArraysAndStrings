namespace LongestPalindromicSubstring
{
    using System.Linq;
    using System.Text;
    using System.Xml.Schema;
    using Microsoft.VisualBasic;

    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var result = "";
            var longestPalindrome = int.MinValue;

            for (int i = 0; i < s.Length; i++)
            {
                var str = new StringBuilder();
                str.Append(s[i]);
                for (int j = i+1; j < s.Length; j++)
                {
                    str.Append(s[j]);

                    if (validPalindrome(str.ToString()))
                    {
                        var res = str.ToString();
                        if (longestPalindrome < res.Length)
                        {
                            result = res;
                        }
                    }
                }
            }
            return result;
        }

        private bool validPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }
    }
}