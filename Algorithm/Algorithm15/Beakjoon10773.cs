using System;
using System.Collections.Generic;

namespace Algorithm15
{
    class Beakjoon10773
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine()!);
            var stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                var input = int.Parse(Console.ReadLine()!);
                if (input == 0)//0이 들어오면 이전 것을 pop
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(input);//그렇지않다면 push
                }
            }
            int sum = 0;
            foreach (var s in stack)
            {
                sum += s;
            }

           Console.WriteLine(sum);
           
        }
    }
}