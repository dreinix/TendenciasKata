using System.Collections.Generic;


namespace RomanNumberIII
{
    public class Roman
    {

        Dictionary<char, int> Values = new Dictionary<char, int>()
        {
            {' ',0 },
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };
        public int Convert(string v)
        {
            int suma = 0,prev=0;
            for (int i = 0; i < v.Length; i++)
            {
                int value = Values[v[i]];
                
                if (i > 0)
                {
                    if (Values[v[i]] != 1 && Values[v[i - 1]] == 1)
                    {
                        suma-=2;
                    }
                    else
                    {
                        if (value > prev)
                        {
                            return -1;
                        }
                    }
                }
                prev = value;
                suma += value;
            }

            if (suma >= 3000)
                return -1;
            return suma;
        }

    }
}
