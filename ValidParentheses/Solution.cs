using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            var charArr = s.ToCharArray();
            var stack = new Stack<char>();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '{' ||
                    charArr[i] == '[' ||
                    charArr[i] == '(')
                {
                    stack.Push(charArr[i]);
                }
                else
                {
                    if (charArr[i] == '}' ||
                        charArr[i] == ']' ||
                        charArr[i] == ')')
                    {
                        if (i == 0)
                        {
                            return false;
                        }

                        char c;
                        stack.TryPeek(out c);

                        if (c == IsClosingFor(charArr[i]))
                        {
                            stack.Pop();
                            continue;
                        }

                        stack.Push(charArr[i]);
                    }
                }
            }

            return stack.Count == 0;
        }

        private char IsClosingFor(char c)
        {
            if (c == '}')
            {
                return '{';
            }

            if (c == ']')
            {
                return '[';
            }

            if (c == ')')
            {
                return '(';
            }

            return Char.MaxValue;
        }
    }
}