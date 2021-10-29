using System;
using System.Collections.Generic;

public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Node PrevNode { get; set; }
        public int PrevCnt { get; set; }

        public Node(int y, int x, Node prevNode)
        {
            this.X = x;
            this.Y = y;
            this.PrevNode = prevNode;

            if (this.PrevNode == null)
            {
                this.PrevCnt = 0;
            }
            else
            {
                this.PrevCnt = PrevNode.PrevCnt + 1;
            }
        }
    }

class Solution {
    public int solution(int[,] maps) {
        return bfs(0, 0, maps.GetLength(0) - 1, maps.GetLength(1) - 1, maps);
    }

    public int bfs(int y, int x, int targetY, int targetX, int[,] maps)
        {
            int[,] direction = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
            bool[,] checkRoad = new bool[maps.GetLength(0), maps.GetLength(1)];

            //방문기록 초기화
            for (int i = 0; i < maps.GetLength(0); i++)
            {
                for (int j = 0; j < maps.GetLength(1); j++)
                {
                    checkRoad[i, j] = false;
                }
            }

            Node bestNode = null;
            Queue<Node> q = new Queue<Node>();
            //시작지점 노드 추가
            q.Enqueue(new Node(y, x, null));
            checkRoad[y, x] = true;

            while (q.Count > 0)
            {
                Node node = q.Dequeue();

                //현노드가 목표지점일때
                if (node.X == targetX && node.Y == targetY)
                {
                    //가장 빠른길이 없거나 현재 노드가 가장 빠른길일 경우
                    if (bestNode == null || bestNode.PrevCnt > node.PrevCnt)
                    {
                        bestNode = node;
                    }
                }

                //노드체크
                for (int i = 0; i < direction.GetLength(0); i++)
                {
                    int dy = node.Y + direction[i, 0];
                    int dx = node.X + direction[i, 1];

                    //맵 범위 안에있는지 확인
                    if (dy >= 0 && dy < maps.GetLength(0) && dx >= 0 && dx < maps.GetLength(1))
                    {
                        //갈 수 있는 길인지 확인
                        if (maps[dy, dx] == 1)
                        {
                            //방문여부 확인
                            if (!checkRoad[dy, dx])
                            {
                                q.Enqueue(new Node(dy, dx, node));

                                //방문체크
                                checkRoad[dy, dx] = true;
                            }
                        }
                    }
                }
            }

            return bestNode == null ? -1 : bestNode.PrevCnt + 1;
        }
}