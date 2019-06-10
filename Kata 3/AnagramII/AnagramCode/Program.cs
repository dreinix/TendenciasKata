using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramC anagram = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\AnagramTests.txt");
            anagram.Solve();
            Console.ReadKey();
        }


    }

    public class AnagramC
    {
        private string[] v;

        public AnagramC(string[] v)
        {
            this.v = v;
        }

        public AnagramC(string v1)
        {
            v = File.ReadAllLines(v1);
        }

        public List<string> Solve()
        {
            List<string> solution = new List<string>();

            if (v.Length > 1)
            {
                System.Collections.Generic.List<IGrouping<string, string>> Ana = v.GroupBy(Word => string.Concat(Word.OrderBy(c => c))).
                      Where(a => a.Count() > 1).ToList();//.ForEach(a=>string.Join(" ",a));
                foreach (var item in Ana)
                {
                    string sol = string.Join(" ", item);
                    solution.Add(sol);
                }
            }

            return solution;
        }
    }
}
