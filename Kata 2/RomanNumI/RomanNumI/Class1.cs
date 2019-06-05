
using System.Collections.Generic;

namespace RomanNumI
{

    public class Roman
    {
        Dictionary<char, int> val = new Dictionary<char, int>()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 }

        };
        public int Convert(string input)
        {
            if (input == "I")
                return 1;
            else
                return 5;
        }
        private int GetVal(char c)
        {

        }
    }
}
