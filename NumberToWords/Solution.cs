using System.Runtime.CompilerServices;

namespace NumberToWords
{
    public class Solution
    {
        private string[] LessThan20 = new[]
        {
            "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
            "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private string[] Tens = new[]
            {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        private string[] Thousands = new[] {"", "Thousand", "Million", "Billion"};

        public string NumberToWords(int num)
        {
            var words = "";
            var i = 0;

            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    words = helper(num % 1000) + " " + Thousands[i] + " " + words;
                }

                num = num / 1000;

                i++;
            }

            return words.Trim();
        }

        private string helper(int num)
        {
            if (num == 0)
            {
                return " ";
            }
            else if (num < 20)
            {
                return LessThan20[num];
            }
            else if (num < 100)
            {
                return Tens[num / 10] + " " + helper(num % 10);
            }
            else
            {
                return LessThan20[num / 100] + " Hundred " + helper(num % 100);
            }
        }
    }
}