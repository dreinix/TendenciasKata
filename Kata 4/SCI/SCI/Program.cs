using System;
using System.Collections.Generic;

namespace SCI
{
    class Program
    {
        static void Main(string[] args)
        {
            SC calc = new SC("1");
            Console.WriteLine(calc.add());
        }
    }

    public class SC
    {
        private string v;

        public SC(string v)
        {
            this.v = v;
        }

        public string add()
        {
            string answer="";
            if (v.Length > 0)
            {
                
                string[] nums = v.Split('\n',',');
                double sum = 0;
                bool error = false;
                foreach (string num in nums)
                {
                    if (double.TryParse(num, out double numVal))
                    {   if (numVal < 0)
                        {
                            answer += "Negative not allowed,";
                            error = true;
                        }
                           
                        sum += (numVal);
                    }
                    else
                    {
                        answer+="Delimiter error,";
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
