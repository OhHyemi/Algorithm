using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm16
{
    class Baekjoon1260
    {
        private static List<int>[] ve;//정점과 정점마다 연결된 다른 정점들의 리스트의 배열
        private static List<int> visited;//방문한 정점

        static void Main(string[] args)
        {
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            ve = new List<int>[input[0] + 1]; //정점의 갯수 만큼 생성.
            visited = new List<int>();
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

            for (int i = 1; i < ve.Length; i++)
            {
                ve[i].Sort();
            }

            DFS(input[2]);
            Console.WriteLine(string.Join(' ', visited));
            visited.Clear();
            
            BFS(input[2]);
            Console.WriteLine(string.Join(' ', visited));
        }

        static void DFS(int v)//dfs
        {
            if (visited.Contains(v)) //이미 방문한  곳이라면 return
            {
                return;
            }

            visited.Add(v);//방문한 정점추가
            for (int i = 0; i < ve[v].Count; i++)
            {
                if (!visited.Contains(ve[v][i]))//방문하지 않은 인접 정점을 방문하러가쟈!
                {
                    DFS(ve[v][i]);
                }
            }
        }
        static void BFS(int v)//bfs
        {
            Queue<int> queue_bfs = new Queue<int>();
            queue_bfs.Enqueue(v);
            visited.Add(v);//방문해따!
            while (queue_bfs.Count > 0)
            {
                var w = queue_bfs.Dequeue();//방문한 정점을 빼면서
            
                for (int i = 0; i < ve[w].Count; i++)//인접한 정점들을 탐색
                {
                    if (!visited.Contains(ve[w][i]))//방문하지 않은 정점이 있다면
                    {
                        queue_bfs.Enqueue(ve[w][i]);
                        visited.Add(ve[w][i]);//방문!
                    }
                }
            }
        }
    }
}