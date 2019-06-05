using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIW3
{
    class Program
    {
        static Dictionary<char, string> EQU = new Dictionary<char, string>(){

            {'0',"Zero"},
            {'1',"one"},
            {'2',"tow"},
            {'3',"three"},
            {'4',"four"},
            {'5',"five"},
            {'6',"six"},
            {'7',"seven"},
            {'8',"eight"},
            {'9',"nine"},
        };
        static Dictionary<string, string> EQD = new Dictionary<string, string>(){

            {"10","ten"},
            {"11","eleven"},
            {"12","tweleve"},
            {"13","thirteen"},
            {"14","fourteen"},
            {"15","fifteen"},
            {"16","six teen"},
            {"17","seve teen"},
            {"18","eight teen"},
            {"19","nine teen"},
            {"2","tweny"},
            {"3","thirty"},
            {"4","forty"},
            {"5","fifty"},
            {"6","sixty"},
            {"7","seventy"},
            {"8","eighty"},
            {"9","ninety"},
        };

        static Dictionary<int, string> BEQ = new Dictionary<int, string>()
        {
            {0,"hundred"},
            {1,"Thousand" },
            {2,"Million" },
            {3,"Billon" }
        };
        static string NIW(int number)
        {
            string converted = "", Snumber = number.ToString();
            int count = -1,actual=1,times=0;

            foreach (char item in Snumber)
            {
                count++;
            }

            for(int i = count; i >= 0; i--)
            {
                switch (actual)
                {
                    case 1:
                        char prev=' ';
                        try
                        {
                            prev = Snumber[i - 1];
                        }
                        catch (Exception)
                        {
                            prev = '0';
                        }
                        if (prev!= '1')
                        {
                            if (i - actual<3)
                            {
                                string mods = BEQ[times];
                                converted = EQU[Snumber[i]] + " " +mods +" " + converted;
                            }   
                            else
                                converted = EQU[Snumber[i]] + " " + converted;
                        }
                        else
                        {
                            if (times != 0)
                            {
                                string mods = BEQ[times];
                                converted = mods + " " + converted;
                            }
                            
                        }

                        actual++;
                        break;
                    case 2:
                        if (Snumber[i] == '1')
                        {
                            string temp = Snumber[i].ToString() + "" + Snumber[i + 1].ToString();
                            converted = EQD[temp] + " " + converted;
                        }
                        else
                        {   
                            converted = EQD[Snumber[i].ToString()] + " " + converted;
                        }
                        
                        actual++;
                        break;
                    case 3:
                        if (times != 0)
                        {
                            string mod = BEQ[0];
                            converted = EQU[Snumber[i]] + " " + mod + " and " + converted;
                        }
                        else
                        {
                            string mod = BEQ[times];
                            converted = EQU[Snumber[i]] + " " + mod + " and " + converted;
                        }
                        
                        actual = 1;
                        times++;
                        break;
                }
            }

            
            return converted+" dollars";
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(NIW(a));
            Console.ReadKey();
        }
    }
}
