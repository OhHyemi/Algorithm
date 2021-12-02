using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm18
{
    class Opera1
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var n = input[0];
            var q = input[1];
            var dictionary = new Dictionary<int, int>(); //결과값과 빈도
            var isCompositionNum = new bool[n + 1];
            
            int max = 0;

            isCompositionNum[0] = true;
            isCompositionNum[1] = true;
            
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isCompositionNum[i] = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < q; i++)
            {
                var testInput = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                int count = 0;
                for (int j = testInput[0]; j <= testInput[1]; j++)
                {
                    if (isCompositionNum[j] == false)
                    {
                        count++;
                    }
                }
                if (dictionary.ContainsKey(count))
                {
                    dictionary[count]++;
                }
                else
                {
                    dictionary.Add(count, 1);
                }
            }

            int key = 0;
            foreach (var kvp in dictionary)
            {
                if (kvp.Value > max)
                {
                    max = kvp.Value;
                    key = kvp.Key;
                }
            }

            Console.WriteLine($"opera_tive의 나이는 {key}입니다!");
        }
    }
}