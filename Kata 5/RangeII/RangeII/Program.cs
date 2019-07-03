using System;

namespace RangeII
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Range
    {
        private string range;
        private int[] ranges = new int[2];
        public class InvalidRangeException : Exception { };
        public Range()
        {
        }

        private int[] GetValues(string newRange)
        {
            int[] Tranges = new int[2];
            string[] srange = newRange.Split(',');

            if (srange[0][0] != '(' && srange[0][0] != '[')
                throw new InvalidRangeException();
            if (srange[1][srange[1].Length - 1] != ')' && srange[1][srange[1].Length - 1] != ']')
                throw new InvalidRangeException();

            if (srange[0][0] == '(')
                Tranges[0] = int.Parse(srange[0].Substring(1, srange[0].Length - 1));
            else
                Tranges[0] = int.Parse(srange[0].Substring(1, srange[0].Length - 1)) - 1;
            if ((srange[1][srange[1].Length - 1] == ')'))
                Tranges[1] = int.Parse(srange[1].Substring(0, srange[1].Length - 1));
            else
                Tranges[1] = int.Parse(srange[1].Substring(0, srange[1].Length - 1)) - 1;
            if (Tranges[0] > Tranges[1])
                throw new InvalidRangeException();

            return Tranges;
        }

        public bool Contain(string v)
        {
            int[] temp = GetValues(v);

            if (ranges[0] < temp[0] && ranges[1] > temp[1])
                return true;

            return false;
        }
        public bool SameAs(string newRag)
        {

            int[] temp = GetValues(newRag);

            if (ranges[0] == temp[0] && ranges[1] == temp[1])
                return true;
            return false;
        }

        public Range(string v)
        {
            this.range = v;

            if (range.Length <= 4 || range == null)
                throw new InvalidRangeException();

            ranges = GetValues(range);
           
        }
    }
}
