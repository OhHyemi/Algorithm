using System;
using System.Linq;

namespace Algorithm9
{
    class Baekjoon9461
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var n = new int[t];
            for (int i = 0; i < t; i++)
            {
                n[i] = int.Parse(Console.ReadLine()!);
            }
            
            var list = n.ToList();
            list.Sort();
            
            var max = list[t - 1];

            var padovan = new long[max];

            padovan[0] = 1;
            padovan[1] = 1;
            padovan[2] = 1;

            while (padovan[^1] == 0)
            {
                for (int i = 3; i < max; i++)
                {
                    if (padovan[i] != 0)
                    {
                        continue;
                    }
                    padovan[i] = padovan[i - 3] + padovan[i - 2];
                }
            }

            var result = new long[t];

            for (int i = 0; i < t; i++)
            {
                result[i] = padovan[n[i] - 1];
            }
            
            Console.WriteLine(String.Join("\n", result));

        }
    }
}