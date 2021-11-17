using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm11
{
    class Baekjoon13116
    {
        static void Main(string[] args)
        {
            int tCount = int.Parse(Console.ReadLine()!);
            var tlist = new List<int>();
            for (int i = 0; i < tCount; i++)
            {
                var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                tlist.AddRange(input);
            }

            for (int i = 0; i < tCount; i++)
            {
                int n1 = tlist[2 * i];
                int n2 = tlist[2 * i + 1];
            
                while (n1 != n2)
                {
                    while (n1 < n2)
                    {
                        n2 /= 2;
                    }
                    if (n1 == n2)
                    {
                        break;
                    }
                    n1 /= 2;
                }
                Console.WriteLine(n1 * 10);
            }
           
        }
    }
}