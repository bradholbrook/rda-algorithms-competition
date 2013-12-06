using System;
using System.Collections.Generic;
using System.Text;

namespace SquareCodeVignere
{
    class Program
    {
        public static Dictionary<char, int> numberFor = new Dictionary<char, int>();
        public static Dictionary<int, char> letterFor = new Dictionary<int, char>();
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < 26; i++)
            {
                numberFor.Add(alpha[i], i);
                letterFor.Add(i, alpha[i]);
            }
            string word = Console.ReadLine().ToUpper();
            int length = word.Length;
            int w = (int)Math.Ceiling(Math.Sqrt(length));
            int h = (int)Math.Floor(Math.Sqrt(length));
            if (w * h < length) h++;
            String key = "RDA";
            int keylength = 3;
            int keyPos = 0;
            String final = "";
            for (int i = 0; i < (int)Math.Ceiling(length / (float)h); i++)
            {
                for (int j = 0; ; j += w)
                {
                    int total = 0;
                    if (i + j >= length) break;
                    Console.Write(word[i + j]);
                    total += numberFor[word[i + j]];
                    total += numberFor[key[keyPos++ % keylength]];
                    final += letterFor[total % 26];
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", final);
            Console.ReadLine();
        }
    }
}
