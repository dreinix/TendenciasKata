using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class InvalidRangeException : Exception { };
    public class Ranges
    {
        private string range;
        private int[] ranges;

        int[] GetRange(string rang)
        {
            string[] rangeS = rang.Split(',');
            int[] Arang = new int[2];
            if (rangeS[0][0] == '(')
                Arang[0] = int.Parse(rangeS[0].Substring(1, rangeS[0].Length - 1));
            else
                Arang[0] = int.Parse(rangeS[0].Substring(1, rangeS[0].Length - 1)) - 1;
            if (rangeS[1][rangeS[1].Length - 1] == ')')
                Arang[1] = int.Parse(rangeS[1].Substring(0, rangeS[1].Length - 1));
            else
                Arang[1] = int.Parse(rangeS[1].Substring(0, rangeS[1].Length - 1)) - 1;

            return Arang;
        }
        public Ranges(string v)
        {
            this.range = v;
            if (range.Length < 5 || range == null)
                throw new InvalidRangeException();

            string[] rangeS = range.Split(',');

            ranges = new int[2];

            ranges = GetRange(v);
            if (ranges[0] > ranges[1]) 
                throw new InvalidRangeException();
        }

        public bool cont(string Nrange)
        {
            string[] rangeS = Nrange.Split(',');
            int[] Nranges = new int[2];
            Nranges = GetRange(Nrange);
            if (ranges[0] <= Nranges[0] && ranges[1] >= Nranges[1])
                return true;
            return false;
        }
    }
}
