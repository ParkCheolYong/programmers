9
branch
branch
branch
branch
branch
merge 5
merge 2
branch
merge 3using System;
using System.Collections.Generic;


public class Solution {

    int[] dirx = { 0, 1, 0, -1 };
    int[] diry = { -1, 0, 1, 0 };

    public int[] solution(string[,] places) {
        int[] answer = new int[5];

            for (int i = 0; i < 5; i++)
            {
                string[] waitingRoom = new string[5];

                for (int j = 0; j < 5; j++)
                {
                    waitingRoom[j] = places[i, j];    
                }

                answer[i] = isArroundExists(waitingRoom);
            }

            return answer;
    }

    public int isArroundExists(string[] pWaitingRoom)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (pWaitingRoom[i][j] == 'P')
                    {
                        if (!bfs(i, j, pWaitingRoom)) return 0;
                    }
                }
            }

            return 1;
        }

    public bool bfs(int x, int y, string[] pWaitingRoom)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(new Node(x,y,0));
            bool[,] visited = new bool[5, 5];
            visited[x, y] = true;
            bool flag = true;

            while (q.Count > 0)
            {
                Node now = q.Dequeue();

                //거리가 2이상이면 스킵
                if (now.Dis >= 2) continue;

                for (int i = 0; i < 4; i++)
                {
                    int nX = now.X + dirx[i];
                    int nY = now.Y + diry[i];
                    int nDis = now.Dis;

                    if (nX >= 0 && nX < 5 && nY >= 0 && nY < 5)
                    {
                        if(!visited[nX,nY])
                        {
                            if (pWaitingRoom[nX][nY] == 'O')
                            {
                                q.Enqueue(new Node(nX, nY, nDis + 1));
                            }
                            else if (pWaitingRoom[nX][nY] == 'P')
                            {
                                if (now.Dis <= 2)
                                {
                                    flag = false;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (!flag) return false;

            }

            return true;
        }


}
 public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Dis { get; set; }

        public Node(int x, int y, int dis)
        {
            X = x;
            Y = y;
            Dis = dis;
        }
    }