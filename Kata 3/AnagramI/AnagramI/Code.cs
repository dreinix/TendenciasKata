using System.Collections.Generic;
using System.IO;

namespace AnagramI
{
    public class Code
    {
    }

    public class AnagramC
    {
        private string[] RawWords;

        private Dictionary<string, string> Words = new Dictionary<string, string>();
        private Dictionary<string, int> freq = new Dictionary<string, int>();
        private string Longest;

        public AnagramC(string[] v)
        {
            this.RawWords = v;
        }
        public AnagramC(string Path)
        {
            this.RawWords =File.ReadAllLines(Path);
        }

        private string SortWord(string word)
        {
            List<char> Dword = new List<char>();
            foreach (char item in word.ToUpper())
            {
                Dword.Add(item);
            }
            Dword.Sort();
            string Oword = "";
            foreach (char item in Dword)
            {
                Oword += item;
            }
            return Oword;
        }

        private void EditDictionary(Dictionary<string,string> D,string key,string value)
        {
            string ana = Words[key];
            Words.Remove(key);
            ana += " " + value;
            Words.Add(key, ana);
        }
        private void EditDictionary(Dictionary<string, int> D, string key)
        {
            int actVal = freq[key];
            freq.Remove(key);
            freq.Add(key, actVal+1);
        }

        public List<string> AnagramSolution()
        {
            List<string> Sol = new List<string>();
            
            if (RawWords.Length > 1)
            {   
                foreach (string word in RawWords)
                {
                    string Oword = SortWord(word);
                    if (Words.ContainsKey(Oword))
                    {
                        EditDictionary(Words, Oword, word);
                        EditDictionary(freq, Oword);
                    }
                    else
                    {
                        Words.Add(Oword, word);
                        freq.Add(Oword, 0);
                    }
                }
                string longest = " ";
                int LongCount=0;
                foreach (var item in Words)
                {
                    if (freq[item.Key] >= 1)
                    {
                        Sol.Add(item.Value);
                        if (freq[item.Key] > LongCount)
                        {
                            LongCount = freq[item.Key];
                            longest = item.Value;
                            
                        }
                            
                    }
                        
                }
                Longest = longest;
            }
             
            return Sol;
        }
        public string LongestAnagramSet()
        {
            AnagramSolution();
            return Longest;
        }
    }
}
