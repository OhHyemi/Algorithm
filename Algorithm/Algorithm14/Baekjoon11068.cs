using System;
using System.Collections.Generic;

namespace Algorithm14
{
    class Baekjoon11068
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var arr = new int[t];
            for (int i = 0; i < t; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            
            for (int i = 0; i < t; i++)
            {
                int result = 0;
                    for (int j = 2; j <= 64; j++)
                    {
                        var convert = ConvertJ(arr[i], j);
                        result = Check(convert);
                        if (result == 1)
                        {
                            break;
                        }
                    }
                
                Console.WriteLine(result);
            }

            int Check(List<int> list)
            {
                for (int i = 0; i < list.Count / 2; i++)
                {
                    if (list[i] != list[list.Count - i - 1])
                    {
                        return 0;
                    }
                }
                return 1;
            }

            List<int> ConvertJ(int value, int j)
            {
                List<int> list = new List<int>();
                
                while (value / j > 0)
                {
                    list.Add(value % j);
                    value /= j;
                }
                list.Add(value);

                return list;
            }
        }
    }
}