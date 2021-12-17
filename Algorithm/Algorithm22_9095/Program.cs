using System;

namespace Algorithm22_9095
{
    class Program
    {
        private static int MAX = 10;
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var rArr = new int[MAX + 1];

            rArr[1] = 1;
            rArr[2] = 2;
            rArr[3] = 4;

            for (int i = 4; i <= MAX; i++)
            {
                rArr[i] = rArr[i - 3] + rArr[i - 2] + rArr[i - 1];
            }

            for (int i = 0; i < t; i++)
            {
                var testcase = int.Parse(Console.ReadLine()!);
                Console.WriteLine(rArr[testcase]);
            }
            
        }
    }
}