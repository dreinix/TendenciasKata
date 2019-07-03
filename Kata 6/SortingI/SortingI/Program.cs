using System;
using System.Collections.Generic;

namespace SortingI
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class NoStringExcepction: Exception { };
    public class InvalidCharacterException: Exception { };
    public class Sorting
    {
        private string Word;

        public Sorting(string v)
        {
            this.Word = v;
        }

        public string Sort()
        {
            if (Word == null || Word.Length < 1)
                throw new NoStringExcepction();

            char tmp='a';
            bool sorted = true;

            List<string> queue = new List<string>();

            foreach (char c in Word)
            {
                if (tmp > c)
                    sorted = false;
                tmp = c;
                if(char.IsLetter(c))
                    queue.Add(c.ToString().ToLower());
            }
        
            if (!sorted)
            {
                queue.Sort();
                Word = string.Empty;
                foreach (string item in queue)
                {
                    Word += item;
                }
            }
                           
            return Word;
        }
    }
}
