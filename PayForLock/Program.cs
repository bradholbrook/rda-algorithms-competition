using System;
using System.Collections.Generic;
using System.Text;

namespace PayForLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int a = 2;
            int y = 5;

            for (int l = 0; l < 10; l++)
            {
                for (int o = 0; o < 10; o++)
                {
                    for (int r = 0; r < 10; r++)
                    {
                        for (int f = 0; f < 10; f++)
                        {
                            for (int c = 0; c < 10; c++)
                            {
                                for (int k = 0; k < 10; k++)
                                {
                                    if (((p * 100) + (a * 10) + y + (f * 100) + (o * 10) + r == (l * 1000) + (o * 100) + (c * 10) + k)
                                        && f != p && f != a && f != y && f != o && f != r && f != l && f != c && f != k
                                        && o != p && o != a && o != y && o != r && o != l && o != c && o != k
                                        && r != p && r != a && r != y && r != l && r != c && r != k
                                        && l != p && l != a && l != y && l != c && l != k
                                        && c != p && c != a && c != y && c != k
                                        && k != p && k != a && k != y)
                                    {
                                        //Console.WriteLine(" PAY " + (int)((p * 100) + (a * 10) + y));
                                        //Console.WriteLine(" FOR " + (int)((f * 100) + (o * 10) + r));
                                        //Console.WriteLine("LOCK " + (int)((l * 1000) + (o * 100) + (c * 10) + k));
                                        Console.WriteLine("P: " + p);
                                        Console.WriteLine("A: " + a);
                                        Console.WriteLine("Y: " + y);
                                        Console.WriteLine("F: " + f);
                                        Console.WriteLine("O: " + o);
                                        Console.WriteLine("R: " + r);
                                        Console.WriteLine("L: " + l);
                                        Console.WriteLine("C: " + c);
                                        Console.WriteLine("K: " + k);

                                        Console.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
