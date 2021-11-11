using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Algorithm6
{
    class Baekjun11866
    {
        static void Main(string[] args)
        {
            //방법1
            // var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            // int n = input[0];
            // int k = input[1];
            //
            // var index = k - 1;
            //
            // Queue result = new Queue();
            // int[] people = new int[n];
            //
            // for (int i = 0; i < n; i++)
            // {
            //     people[i] = i + 1;
            // }
            //
            // //배열로 하는 풀이
            // while (result.Count != n)//결과의 갯수가 n 값이 아닌동안
            // {
            //     if (people[index] > 0)//값이 0보다 크면
            //     {
            //         result.Enqueue(people[index]);//결과에 enqeue
            //         people[index] = 0;//결과에 넣은 값은 0으로
            //     }
            //
            //     if (result.Count == n)
            //     {
            //         break;
            //     }
            //
            //     for (int i = 0; i < k; i++)//k번동안 인덱스 변경
            //     {
            //         index = (index + 1) % n;//n의 크기를 넘지 않도록 설계
            //         while(people[index] == 0)//값이 0인 경우 횟수로 치지 않음
            //         {
            //             index = (index + 1) % n;
            //         }
            //     }
            // }
            //
            // StringBuilder st = new StringBuilder();
            //
            // st.Append("<");
            // st.Append(string.Join(", ", result.ToArray()));
            // st.Append(">");
            //
            // Console.WriteLine(st);
            
            //방법2
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            Queue result = new Queue();
            Queue que = new Queue();
            for (int i = 1; i <= n; i++)
            {
                que.Enqueue(i);
            }
            //queue를 이용한 풀이
            while (result.Count != n)
            {
                for (int i = 0; i < k - 1; i++)//k-1번째까지는 dequeue 후 다시 enqueue 
                {
                    var pop =que.Dequeue();
                    que.Enqueue(pop);
                }
                result.Enqueue(que.Dequeue());//k번째에 결과값에 추가
            }

            var r = string.Join(", ", result.ToArray());
            Console.WriteLine($"<{r}>");
        }
    }
}