using System;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str.Trim()))
            {
                return 0;
            }

            var result = 0;

            bool signFound = false;

            var strArr = str.Trim().ToCharArray();

            var sb = new StringBuilder();

            for (int i = 0; i < strArr.Length; i++)
            {
                if ((strArr[0] == '-' || strArr[0] == '+') && i == 0 && strArr.Length >0 )
                {
                    signFound = true;
                    continue;
                }

                if (!char.IsDigit(strArr[0]) && i == 0)
                {
                    return 0;
                }

                if (char.IsDigit(strArr[i]))
                {
                    sb.Append(strArr[i]);
                }
                else
                {
                    break;
                }
            }

            if (string.IsNullOrEmpty(sb.ToString()))
            {
                return 0;
            }
            var res = int.TryParse(sb.ToString(), out result);
            if (!res)
            {
                result = int.MinValue;
            }

            if (signFound)
            {
                return strArr[0] == '-' ? result * -1 : result;
            }

            return result;
        }
    }
}