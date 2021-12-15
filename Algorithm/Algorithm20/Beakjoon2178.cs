using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm20
{
    class Beakjoon2178
    {
        struct Point
        {
            public  int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var N = input1[0];
            var M = input1[1];

            var maze = new char[N, M];
            var distance = new int[N * M];// x,y를 하나의 index화 시켜 사용 
            var distance2 = new int[N , M];// point라는 struct를 만들어 각 x,y를 그대로 활용
            
            var dx = new int[] { 1, 0, -1, 0 };
            var dy = new int[] { 0, 1, 0, -1 };
            
            for (int i = 0; i < N; i++)
            {
                var input = Console.ReadLine()!.ToCharArray();
                for (int j = 0; j < M; j++)
                {
                    maze[i, j] = input[j];
                }
            }
            maze[0, 0] = '2';
            
            //BFSByIndex(0, 0);
            BFSByStruct(0,0);
            
            //Console.WriteLine(distance[^1]);
            Console.WriteLine(distance2[N-1, M-1]);

            void BFSByIndex(int s_x, int s_y)
            {
                Queue<int> queue = new Queue<int>();
               
                var startIndex = s_x * M + s_y;
                queue.Enqueue(startIndex);

                distance[startIndex] = 1;

                int i_x; //index_x
                int i_y; //inex_y
                
                while (queue.Count > 0)
                {
                    var value = queue.Dequeue();

                    i_x = value / M;
                    i_y = value % M;
                    
                    for (int k = 0; k < 4; k++) //4방향을 확인!
                    {
                        var newX = i_x + dx[k];
                        var newY = i_y + dy[k];
                        if (newX >= N || newX < 0 || newY >= M || newY < 0)
                        {
                            continue;
                        }
                        
                        if (maze[newX, newY] == '1') //방문하지않았고 길이 있으면 방문!
                        {
                            var index = newX * M + newY;
                            queue.Enqueue(index);

                            var originIndex = i_x * M + i_y;
                            
                            distance[index] = distance[originIndex] + 1;
                            maze[newX, newY] = '2';
                        }
                    }
                }
            }
            void BFSByStruct(int s_x, int s_y)
            {
                Queue<Point> queue = new Queue<Point>();
                
                queue.Enqueue(new Point(s_x, s_y));

                distance2[s_x, s_y] = 1;
                
                while (queue.Count > 0)
                {
                    var value = queue.Dequeue();

                    for (int k = 0; k < 4; k++) //4방향을 확인!
                    {
                        var newX = value.x + dx[k];
                        var newY = value.y + dy[k];
                        if (newX >= N || newX < 0 || newY >= M || newY < 0)
                        {
                            continue;
                        }
                        
                        if (maze[newX, newY] == '1') //방문하지않았고 길이 있으면 방문!
                        {
                            queue.Enqueue(new Point(newX, newY));

                            distance2[newX, newY] = distance2[value.x, value.y] + 1;
                            maze[newX, newY] = '2';
                        }
                    }
                }
            }
        }
    }
}