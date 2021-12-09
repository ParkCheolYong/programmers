using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] edge)
    {
        List<int>[] list = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            list[i] = new List<int>();
        }
        Queue<int> q = new Queue<int>();
        bool[] visited = new bool[n + 1];
        int[] depth = new int[n + 1];

        for (int i = 0; i < edge.GetLength(0); i++)
        {
            list[edge[i, 0]].Add(edge[i, 1]);

            list[edge[i, 1]].Add(edge[i, 0]);
        }

        q.Enqueue(1);
        visited[1] = true;

        int maxDepth = 0;

        while (q.Count > 0)
        {
            int node = q.Dequeue();

            for (int i = 0; i < list[node].Count(); i++)
            {
                if (!visited[list[node][i]])
                {
                    q.Enqueue(list[node][i]);
                    visited[list[node][i]] = true;
                    depth[list[node][i]] = depth[node] + 1;
                    maxDepth = Math.Max(maxDepth, depth[list[node][i]]);
                }
            }
        }

        return depth.Count(x => x == maxDepth);
    }
}