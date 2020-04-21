using System.Text;

namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var m = a.Length - 1;
            var n = b.Length - 1;
            var carry = 0;
            var sb = new StringBuilder();

            while (m >= 0 || n >= 0)
            {
                var val1 = m >= 0 ? a[m--] - '0' : 0;
                var val2 = n >= 0 ? b[n--] - '0' : 0;

                var sum = val1 + val2 + carry;
                sb.Insert(0, sum % 2);
                carry = sum / 2;
            }

            return carry == 1 ? sb.Insert(0, 1).ToString() : sb.ToString();
        }
    }
}