using System.Collections.Generic;

namespace RomanNumII
{

    public class Roman
    {
        Dictionary<char, int> Values = new Dictionary<char, int>()
        {
            {' ',0 },
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50},
            {'C',100 },
            {'D',500 },
            {'M',1000 }

        };
        public int Convert(string In)
        {
            int sum = 0;
            for (int i = 0; i < In.Length; i++)
            {
                int val = Values[In[i]];
                if (i > 0)
                {
                    if (In[i] != 'I' && In[i - 1] == 'I')
                        val -= 2;
                }

                sum += val;
            }
            if (sum > 2999)
                return -1;
            return sum;
        }

    }
}
