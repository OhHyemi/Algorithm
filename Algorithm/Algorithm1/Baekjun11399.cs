using System;
using System.Linq; 	

namespace Algorithm
{
    class Baekjun11399
    {
        public static void Main()
        {
            int people = int.Parse(Console.ReadLine()!);

            //시간이 가장 적은 사람이 순으로 줄을 서면 전체가 돈을 인출하는 시간의 총합이 줄어들음
            var list = Console.ReadLine()!.Split(' ').Select((int.Parse)).ToArray();
            Array.Sort(list); //정렬

            var result = list[0];

            for (int i = 1; i < list.Length; ++i)
            {
                list[i] = list[i - 1] + list[i];
                result += list[i]; //걸리는 시간 더하기
            }

            Console.WriteLine(result);
        }
    }
}