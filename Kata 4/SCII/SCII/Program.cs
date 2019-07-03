using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCII
{
    class Program
    {
        static void Main(string[] args)
        {
            SC convert = new SC("5\n6,10,9");
            convert.calc();
            Console.ReadKey();
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

        public string calc()
        {
            string ans = "";
            bool error = false;

            if (v.Length > 0)
            {
                string[] nums;
                if (c!=null)
                {
                    nums = v.Split(c);
                }
                else
                {
                    nums = v.Split(',','\n');
                }
                
                double sum=0;
                foreach (string item in nums)
                {
                    if(Double.TryParse(item, out double num))
                    {
                        if (num < 0)
                        {
                            error = true;
                            if (!ans.Contains("Negative not allow,"))
                                ans += "Negative not allow,";

                        }

                        sum += num;
                    }
                    else
                    {
                        error = true;
                        if(!ans.Contains("Parse error,"))
                            ans += "Parse error,";
                    }
                    
                }
                if (!error)
                    ans = sum.ToString();
                return ans;
            }
            return "0";
        }
    }
}
