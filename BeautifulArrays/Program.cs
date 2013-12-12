using System;
using System.Collections.Generic;
using System.Text;

namespace BeautifulArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            int max_ending_here = 0, max_so_far = 0;
            for (int i = 0; i < n; i++)
            {
                max_ending_here = Math.Max(0, max_ending_here + array[i]);
                max_so_far = Math.Max(max_so_far, max_ending_here);
            }
            Console.WriteLine(max_so_far);
            Console.ReadLine();
        }
    }
}
