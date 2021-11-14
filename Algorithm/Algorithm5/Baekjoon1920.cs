using System;
using System.Linq;
using System.Text;

namespace Algorithm5
{
    class Baekjun1920
    {
        static void Main(string[] args)
        {
           
            var count_n = int.Parse(Console.ReadLine()!);
            var n = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var count_m = int.Parse(Console.ReadLine()!);
            var m = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var result = new int[m.Length];

            Array.Sort(n);

            for (int i = 0; i < count_m; i++)
            {
                if (m[i] < n[0] || m[i] > n[^1]) //값이 범위에서 벗어나면 0
                {
                    result[i] = 0;
                    continue;
                }
                
                int pivot = count_n / 2; //이진탐색을 활용!
                int left = 0;
                int right = count_n - 1;

                while (true)
                {
                    if (left > right)
                    {
                        result[i] = 0;
                        break;
                    }
                    else
                    {
                        if (m[i] == n[pivot]) // 피봇과 값이 같은 경우
                        {
                            result[i] = 1;
                            break;
                        }
                        else if (m[i] > n[pivot]) // 피봇의 값보다 큰 경우
                        {
                            left = pivot + 1;
                        }
                        else // 피봇의 값보다 작은 경우
                        {
                            right = pivot - 1;
                        }
                        pivot = (left + right) / 2;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", result));
        }
    }
}