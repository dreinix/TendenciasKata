using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInWords
{
    class Program
    {
        static Dictionary<string, string> NumbersEq = new Dictionary<string, string>()
        {
            {"0"," "},
            {"1","One"},
            {"2","Two" },
            {"3","Three" },
            {"4","Four" },
            {"5","Five" },
            {"6","Six" },
            {"7","Seven" },
            {"8","Eight" },
            {"9","Nine" },
            {"10","Ten" },
            {"11","Eleven" },
            {"12", "Twelve" }

        };
        static Dictionary<int, string> Escale = new Dictionary<int, string>()
        {
            {0," " },
            {1,"ty"},
            {2," Houndred" },
            {3," Thousand " },
            {6," Million"}

        };
        static string IntoWords(int number)
        {
            string converted = "";
            int digits = 0;
            foreach (var item in number.ToString())
            {
                digits++;
            }

            if (number > 30)
            {
                foreach (char item in number.ToString())
                {

                    NumbersEq.TryGetValue(item.ToString(), out string eq);
                    Escale.TryGetValue(digits - 1, out string EscaleEq);
                    converted += eq + "" + EscaleEq+" ";
                    digits--;
                    number -= Convert.ToInt32(item);
                }
                
            }
            

            return converted;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(IntoWords(74525));

            Console.ReadKey();
        }
    }
}
