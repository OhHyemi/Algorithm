using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm10
{
    class Baekjon1541
    {
        static void Main(string[] args)
        {
            var op = new char[] {'+', '-'};
            var input = Console.ReadLine();
            var opList =  input!.ToCharArray().Where(a => a is '+' or '-').ToArray();
            var nList = input!.Split(op).Select(int.Parse).ToArray();//연산자를 기준으로 SPLIT

            if (nList.Length == 1) //수 하나만 들어왔을 경우(연산자가 없는 경우)
            {
                Console.WriteLine(nList[0]);
                return;
            }
            int re = nList[0];

            List<int> results = new List<int>();//결과값들을 저장해 놓을 공간(-기준으로 끊어 +연산한 값들)

            for (int i = 0; i < opList.Length; i++)
            {
                if (opList[i] == '+')
                {
                   re += nList[i + 1];
                }
                else
                {
                    results.Add(re);//-를 만나기 전까지 더한 수의 합을 ADD
                    re = nList[i + 1];// -를 만난 후 다음 수
                }

                if (i == opList.Length - 1)//다음 연산자가 없을 경우
                {
                    results.Add(re);
                }
            }

            var result = results[0];

            for (int i = 1; i < results.Count; i++)
            {
                result -= results[i];//처음 값에서 나머지 값을 모두 빼줌
            }
            
            Console.WriteLine(result);
        }
    }
}