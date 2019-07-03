using System;

namespace SCI
{
    class Program
    {
        static void Main(string[] args)
        {
            SC calc = new SC("1\n2;3,4,\n5", new char[] { '\n', ',', ';' });
            Console.WriteLine(calc.add());
        }
    }

    public class SC
    {
        private string v;
        private char[] c;

        public SC(string v)
        {
            this.v = v;
        }

        public SC(string v, char[] v1) : this(v)
        {
            this.c = v1;
        }

        public string add()
        {
            string answer="";
            if (v.Length > 0)
            {
                string[] nums;
                if (c != null)
                {
                    nums = v.Split(c);
                }
                else
                {
                    nums = v.Split('\n', ',');
                }
                
                 
                double sum = 0;
                bool error = false;
                int i = 0;
                foreach (string num in nums)
                {
                    i++;
                    if (double.TryParse(num, out double numVal))
                    {   if (numVal < 0)
                        {
                            answer += string.Format("Negative not allowed:{0} ,",numVal);
                            error = true;
                        }
                           
                        sum += (numVal);
                    }
                    else
                    {
                        char errorD= v[2*(i-1)];
                        answer+=string.Format("Delimiter error:{0} ,", errorD);
                        error = true;
                    }

                }
                if (!error)
                    answer = sum.ToString();
            }
            else
            {
                return "0";
            }

            return answer;
        }
    }
}
