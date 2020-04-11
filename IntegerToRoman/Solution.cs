namespace IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var units = new[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            var tens = new[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "LC"};
            var hundreds = new[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "DM"};
            var thousands = new[] {"", "M", "MM", "MMM"};


            return thousands[(num / 1000)] + hundreds[(num % 1000) / 100] + tens[(num % 100) / 10] + units[num % 10];

        }
    }
}