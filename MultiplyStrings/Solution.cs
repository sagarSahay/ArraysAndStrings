using System.Text;

namespace MultiplyStrings
{
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            var i = num1.Length;
            var j = num2.Length;

            var result = new int[i + j];

            for (int k = i - 1; k >= 0; k--)
            {
                for (int l = j - 1; l >= 0; l--)
                {
                    var mul = (num1[k] - '0') * (num2[l] - '0');
                    var sum = result[k + l + 1] + mul;
                    result[k + l] += sum / 10;
                    result[k + l + 1] = sum % 10;
                }
            }

            var sb = new StringBuilder();
            foreach (var x in result)
            {
                if (sb.Length > 0 || x != 0)
                {
                    sb.Append(x);
                }
            }

            return sb.Length == 0 ? "0": sb.ToString();
        }
    }
}