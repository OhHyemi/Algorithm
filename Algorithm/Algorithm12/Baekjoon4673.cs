using System;
using System.Linq;

namespace Algorithm12
{
    class Baekjoon4673
    {
        static void Main(string[] args)
        {
            var arr = new bool[10000]; //생성자가 있는 지 없는 지 체크해주는 배열!

            for (int i = 0; i < arr.Length; i++)
            {
                var n = i + 1; //실제 체크해야 하는 수는 인덱스 보다 1 더 큼.
                
                if (arr[i] == false) //만약 생성자가 없다면
                {
                    Console.WriteLine(n);//출력
                }

                var list = n.ToString().ToArray();//수를 array 로 변환
                foreach (var num in list)
                {
                    n += num - '0';//수에 각 자리 수를 더함
                }
                
                if (n - 1 < arr.Length)//만약 인덱스가 arr의 길이보다 작을 경우에는
                {
                    arr[n - 1] = true;//생성자가 있다고 true 로 변경하기
                }
            }
        }
    }
}