using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIW2
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
            {"7","secenty"},
            {"8","eighty"},
            {"9","ninety"},
        };

        public static string ConvertIntoWord(int number)
        {
            string endWord = "",Snumber=number.ToString();
            int charCount = 0, actual = 1,times = 0;
            foreach (char c in number.ToString())
            {
                charCount++;
            }

            for(int i = charCount-1;i>=0; i--)
            {
                switch (actual)
                {
                    case 1:
                        if (Snumber[i-1]!= '1')
                            endWord = EQU[Snumber[i]] + " " + endWord;
                        actual++;
                        break;
                    case 2:
                        char temp = Snumber[i];
                        if ( temp == '1')
                        {
                            string temp2 = Snumber[i].ToString() +"" +Snumber[i + 1].ToString();
                            endWord = EQD[temp2];
                        }
                            
                        else
                            endWord = EQD[Snumber[i].ToString()] + " " + endWord;
                        actual++;
                        break;
                    case 3:
                        string mod = "hundred";
                        endWord = EQU[Snumber[i]] + " "+mod+" and " + endWord;
                        actual = 1;
                        break;


                }
                 
            }

            return endWord;
        }

        static void Main(string[] args)
        {
            int a = 968;
            Console.WriteLine(ConvertIntoWord(a));

            Console.ReadKey();

        }
    }
}
