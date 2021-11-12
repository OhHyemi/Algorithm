using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm7
{
    class Beakjun1929
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int m = list[0];
            int n = list[1];

            List<int> result = new List<int>();
            //소수의 정의 : 1과 자기자신으로 밖에 나눌 없는 것..
            //소수는 다 홀수이다. => 2x+ 1 (x >= 0)
            // y(2x + 1) => 가 아닌 나머지 홀수 (y > 1)
            
            for (int i = m; i <= n; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if (i is > 1 and < 4)
                {
                    result.Add(i);
                    continue;
                }
                if (i % 2 == 0)
                {
                    continue;
                }
                bool primeNum = true;
                for (int k = 1; (k * 2 + 1) <= Math.Sqrt(i); k++)
                {
                    if (i % (k * 2 + 1) == 0)
                    {
                        primeNum = false;
                        break;
                    }
                }
                if (primeNum == true)
                {
                    result.Add(i);
                }
              
            }
            StringBuilder sb = new StringBuilder(String.Join("\n", result.ToArray()));
  
            Console.WriteLine(sb);
        }
    }
}

