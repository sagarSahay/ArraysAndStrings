namespace ImplemenStrStr
{
    using System.Runtime.InteropServices;

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            // var haystackLength = haystack.Length;
            // var needleLength = needle.Length;
            //
            // for (int i = 0; i < haystackLength - needleLength + 1; i++)
            // {
            //     if (haystack.Substring(i, needleLength).Equals(needle))
            //     {
            //         return i;
            //     }
            // }
            //
            // return -1;

            var haystackLength = haystack.Length;
            var needleLength = needle.Length;

            var haystackPtr = 0;
            
            while (haystackPtr < haystackLength - needleLength + 1)
            {
                if (haystack[haystackPtr] != needle[0] && haystackPtr< haystackLength - needleLength +1)
                {
                    haystackPtr++;
                }

                var currlen = 0;
                var needlePtr = 0;
                while (haystackPtr < haystackLength && needlePtr < needleLength &&
                       haystack[haystackPtr] == needle[needlePtr])
                {
                    haystackPtr++;
                    needlePtr++;
                    currlen++;
                }

                if (currlen == needleLength)
                {
                    return haystackPtr - currlen;
                }

                haystackPtr = haystackPtr - currlen + 1;


            }

            return -1;
        }
    }
}