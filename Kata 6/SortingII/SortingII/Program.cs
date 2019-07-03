using System;
using System.Collections.Generic;

namespace SortingII
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Sorting
    {
        private string v;

        public Sorting(string v)
        {
            this.v = v;
        }

        public string Sort()
        {   
            if(v==null || v.Length<1)
                return null;

            bool sorted=true;
            char tmp = 'a';
            foreach (char c in v)
            {
                if (tmp > c)
                    sorted = false;
                tmp = c;
            }
            if (!sorted)
            {
                List<string> stack = new List<string>();
                foreach (var item in v)
                {   
                    if(char.IsLetter(item))
                        stack.Add(item.ToString().ToLower());
                }
                v = string.Empty;
                if (stack.Count == 0)
                    return null;
                stack.Sort();
                foreach (var item in stack)
                {
                    v += item;
                }
            }
                
            return v;
        }
    }
}
