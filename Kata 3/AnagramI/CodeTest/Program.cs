using AnagramI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramC code = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\INPUT.txt");
            code.AnagramSolution();
            code.LongestAnagramSet();
        }
    }
}
