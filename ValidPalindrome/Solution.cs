using System;
using System.Linq;
using System.Text;

namespace ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s) 
        {
            var sb = new StringBuilder();

            foreach (var c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLower(c));
                }
            }

            var x = sb.ToString();
            var y = sb.ToString().Reverse();
            return x == new string(y.ToArray());
        }
    }
}