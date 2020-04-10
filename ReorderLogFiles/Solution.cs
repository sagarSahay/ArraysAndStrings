using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ReorderLogFiles
{
    public class Solution
    {
        public string[] ReorderLogFiles(string[] logs) 
        {
            Array.Sort(logs, (x, y) =>
            {
                var split1 = x.Split(' ', 2);
                var split2 = y.Split(' ', 2);

                var isDigit1 = char.IsDigit(split1[1].ToCharArray()[0]);
                var isDigit2 = char.IsDigit(split2[1].ToCharArray()[0]);

                if (!isDigit1 && !isDigit2)
                {
                    var cmp = x.CompareTo(y);
                    if (cmp !=0)
                    {
                        return cmp;
                    }

                    return split1[0].CompareTo(split2[0]);
                }

                return isDigit1 ? (isDigit2 ? 1 : 0) : -1;
            });

            return logs;

        }
    }
}