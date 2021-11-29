using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm17
{
    class Baekjoon11724
    {
        private static List<int>[] ve;
        static List<int> visited;

        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            ve = new List<int>[input[0] + 1];

            for (int i = 1; i < input[0] + 1; i++)
            {
                ve[i] = new List<int>();
            }

            for (int i = 1; i <= input[1]; i++)
            {
                var input2 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                ve[input2[0]].Add(input2[1]);
                ve[input2[1]].Add(input2[0]);
            }

            visited = new List<int>();
            int count = 0; //연결된 요소 카운트

            for (int i = 1; i < ve.Length; i++)
            {
                var list = new List<int>();
                if (!visited.Contains(i))//방문한 곳이 아니라면
                {
                    DFS(i,list);
                    if (list.Count > 0)//연결된 정점들이 하나 이상이면
                    {
                        visited.AddRange(list); //방문한 정점 추가
                        count++;//연결 요소 카운트 ++
                    }
                }
            }
            Console.WriteLine(count);
        }
        static void DFS(int v, List<int> result) //dfs
        {
            if (result.Contains(v)) //이미 방문한  곳이라면 return
            {
                return;
            }
            result.Add(v); //방문한 정점추가
            for (int i = 0; i < ve[v].Count; i++)
            {
                if (!result.Contains(ve[v][i])) //방문하지 않은 인접 정점을 방문하러가쟈!
                {
                    DFS(ve[v][i], result);
                }
            }
        }
    }
}
