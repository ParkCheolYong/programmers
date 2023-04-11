using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string[] maps) 
    {
        int startX = 0;
        int startY = 0;
        int leverX = 0;
        int leverY = 0;
        int endX = 0;
        int endY = 0;

        for (int i = 0; i < maps.Length; i++)
        {
            for (int j = 0; j < maps[0].Length; j++)
            {
                if (maps[i][j] == 'S')
                {
                    startX = j;
                    startY = i;
                }
                else if (maps[i][j] == 'L')
                {
                    leverX = j;
                    leverY = i;
                }
                else if (maps[i][j] == 'E')
                {
                    endX = j;
                    endY = i;
                }
            }
        }

        int l = bfs(startY, startX, leverY, leverX, maps);
        int e = bfs(leverY, leverX, endY, endX, maps);
        
        if (l == -1 || e == -1)
        {
            return -1;
        }
        else
        {
            return l + e;
        }
    }
    
    public int bfs(int y, int x, int targetY, int targetX, string[] maps)
    {
        int[,] direction = new int[,] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
        bool[,] visited = new bool[maps.Length, maps[0].Length];

        Node bestNode = null;
        Queue<Node> q = new Queue<Node>();

        q.Enqueue(new Node(y, x, null));
        visited[y,x] = true;

        while(q.Count > 0)
        {
            Node node = q.Dequeue();

            //현 노드가 목표지점일 때
            if (node.X == targetX && node.Y == targetY)
            {
                //가장 빠른 길이 없거나 현재노드가 가장 빠를때 베스트노드 갱신
                if (bestNode == null || bestNode.PrevCnt > node.PrevCnt)
                {
                    bestNode = node;
                }
            }

            //네방향 탐색
            for (int i = 0; i < direction.GetLength(0); i++)
            {
                int nextY = node.Y + direction[i,0];
                int nextX = node.X + direction[i,1];

                //다음좌표가 맵의 범위 안에 있고
                //방문한적이 없으며
                //갈 수 있는 길인 경우
                if (nextY >= 0 && nextY < maps.Length && nextX >= 0 && nextX < maps[0].Length
                    && !visited[nextY, nextX]
                    && maps[nextY][nextX] != 'X')
                {
                    visited[nextY, nextX] = true;
                    q.Enqueue(new Node(nextY, nextX, node));
                }
            }
        }

        return bestNode == null ? -1 : bestNode.PrevCnt;
    }
}

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
            this.PrevCnt = prevNode.PrevCnt + 1;
        }
    }
}