using System;
using System.Collections.Generic;

namespace Algorithm19
{
    class Baekjoon2667
    {
        static void Main(string[] args)
        {
            char house = '1';
            char visitedHouse = '2';
            
            int N = int.Parse(Console.ReadLine()!);
            var arr = new char[N,N];
            var list = new char[N];
            for (int i = 0; i < N; i++)
            {
                list = Console.ReadLine()!.ToCharArray();
                for (int j = 0; j < N; j++)
                {
                    arr[i,j] = list[j];
                }
            }
            
            List<int> countList = new List<int>();

            int c = 0;
            for (int r= 0; r < N; r++)
            {
                for (; c < N; c++)
                {
                    if (arr[r, c] != house)
                    {
                        continue;
                    }
                    countList.Add(DFS(r, c));
                }
                c = 0;
            }
            
            Console.WriteLine(countList.Count);

            countList.Sort();
            for (int i = 0; i < countList.Count; i++)
            {
                Console.WriteLine(countList[i]);
            }
            
            // 상하좌우(4 Way) 움직임.. 방법 1
            // int[] dx = {0, 1, 0, -1};
            // int[] dy = {1, 0, -1, 0};
            int DFS(int r, int c)
            {
                int cnt = 0;
                if (arr[r, c] == house)
                {
                    arr[r, c] = visitedHouse;
                    cnt++;
                }
                
                // for(int d = 0; d < 4; d++) // 상하좌우 탐색
                // {
                //     int nX = x + dx[d]; // 새로운 x좌표
                //     int nY = y + dy[d]; // 새로운 y좌표
                //
                //     if(nX < 0 || nX >= N || nY < 0 || nY >= N) // Out of Bound 체크 - 맵의 경계를 넘어가나 체크하는 것이다.
                //         continue;
                //
                //     if(board[nX, nY] == house) // 새로 이동할 위치에 아파트 건물이 있고, 아직 방문하지 않은 정점이라면
                //         DFS(nX, nY); // 이 위치에서 DFS 호출
                // }
                
                //방법2 
                if (r + 1 < N && arr[r + 1, c] == house) //오른쪽
                {
                    cnt += DFS(r + 1, c);
                }

                if (r - 1 >= 0 && arr[r - 1, c] == house) //왼쪽
                {
                    cnt += DFS(r - 1, c);
                }

                if (c - 1 >= 0 && arr[r, c - 1] == house) //아래쪽
                {
                    cnt += DFS(r, c - 1);
                }
                
                if (c + 1 < N && arr[r, c + 1] == house) //위쪽
                {
                    cnt += DFS(r, c + 1);
                }

                return cnt;
            }
        }
    }
}