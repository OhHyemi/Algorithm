using System;

namespace Algorithm21
{
    class Beakjoon11727
    {
        private static long mod = 10007;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            long[] arr = new long[n + 1];

            arr[1] = 1; //1*2 블록 하나
            if (n > 1)
            {
                arr[2] = 3; //2*2 블록 하나 or 2*1블록 둘 or 1*2블록 둘
            }

            //방법1
            // 한 칸이 비워져 있다고 했을 때 그 한 칸을 채우는 방법은 하나이다. 
            // 두 칸이 비워져 있다고 했을 때 그 두 칸을 채우는 방법은 세가지 이지만,
            // 1*2블록 둘의 경우는 한 칸이 비워져 있을 경우랑 같은 경우로 생각할 수 있다.
            // 따라서, 2*2 블록 하나 or 2*1블록 둘 -> 두가지의 방법이 있다.
            // 3부터 arr[n] = arr[n - 1] + 2 * arr[n - 2]
            
            for (int i = 3; i <= n; i++)
            {
                arr[i] = (arr[i - 1] + 2 * arr[i - 2]) % mod;
            }

            Console.WriteLine(arr[n]);

            //방법2->규칙을 찾았다. [n번째의 값] = 2^(n-1) + [n-2번째의 값]
            long GetAn(int index)
            {
                if (arr[index] != 0)
                {
                    return arr[index];
                }
                

                arr[index] = (MyPownMod(2, index - 1) + GetAn(index - 2)) % mod;
                return arr[index];
            }

            Console.WriteLine(GetAn(n));
        }

        //빠른 거듭제곱 알고리즘.. + MOD 
        static long MyPownMod(long _base, long _exp)
        {
            long let = 1;
            while (_exp > 1)
            {
                var temp = _exp & 1; //홀수냐 짝수냐
                if (temp == 1) //홀수
                {
                    let = (_base * let) % mod; 
                    //mod를 계속 해주는 이유
                    //값이 넘어가 overflow가 될 수 있기 때문... 
                }

                _base = _base * _base % mod;
                _exp >>= 1;
            }

            return (_base * let) % mod;
        }
    }
}