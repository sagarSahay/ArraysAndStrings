using System.Collections;
using System.Collections.Generic;

namespace RomanToInteger
{
    public class Solution
    {
        public int RomanToInt(string s) 
        {
            var romanDict = new Dictionary<char,int>();
            romanDict.Add('I',1);
            romanDict.Add('V',5);
            romanDict.Add('X',10);
            romanDict.Add('L',50);
            romanDict.Add('C',100);
            romanDict.Add('D',500);
            romanDict.Add('M',1000);

            var result = 0;
            var romanArray = s.ToCharArray();

            for (int i = 0; i < romanArray.Length; i++)
            {
                if (i > 0 && romanDict[romanArray[i]] > romanDict[romanArray[i - 1]])
                {
                    result += romanDict[romanArray[i]] - 2 * romanDict[romanArray[i - 1]];
                }
                else
                {
                    result += romanDict[romanArray[i]];
                }
            }

            return result;
        }
    }
}