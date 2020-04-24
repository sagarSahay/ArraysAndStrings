namespace ReadNCharacterGivenRead4
{
    public class Solution : Reader4 
    {
        /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
        public int Read(char[] buf, int n)
        {
            var mem = new char[4];
            var totalWords = 0;
            while (true)
            {
                var count = Read4(mem);
                if (totalWords < n)
                {
                    for (int i = 0; i <= count; i++)
                    {
                        buf[i] = mem[i];
                        totalWords += 1;
                    }
                }
                else
                {
                    break;
                }

                if (count < n)
                {
                    break;
                }
                
            }

            return totalWords;
        }
    }

    public class Reader4
    {
        public int Read4(char[] buf)
        {
            return 0;
        }
    }
}