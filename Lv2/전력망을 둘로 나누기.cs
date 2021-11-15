using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] wires)
    {
        bool[,] map = new bool[n + 1,n + 1];
        List<int> nodeCntDiffList = new List<int>();


        for (int i = 0; i < wires.GetLength(0); i++)
        {
            map[wires[i, 0], wires[i, 1]] = map[wires[i, 1], wires[i, 0]] = true;
        }

        for (int i = 0; i < wires.GetLength(0); i++)
        {
            map[wires[i, 0], wires[i, 1]] = map[wires[i, 1], wires[i, 0]] = false;

            bool[] visited = new bool[n + 1];
            int nodeCnt = bfs(1, n, visited, map);

            nodeCntDiffList.Add(Math.Abs(nodeCnt - (n - nodeCnt)));

            map[wires[i, 0], wires[i, 1]] = map[wires[i, 1], wires[i, 0]] = true;
        }


        return nodeCntDiffList.Min();
    }

    public int bfs(int now, int n, bool[] visited, bool[,] map)
    {
        visited[now] = true;

        for (int i = 1; i <= n; i++)
        {
            if (map[now, i] && !visited[i])
            {
                bfs(i, n, visited, map);
            }
        }

        return visited.Count(x => x == true);
    }
}