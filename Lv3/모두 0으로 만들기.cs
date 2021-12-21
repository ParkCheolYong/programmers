using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    long answer = 0;
    long[] long_a;

    public long solution(int[] a, int[,] edges)
    {
        if (a.Sum() != 0) return -1;

        bool[] visited = new bool[a.Length];
        long_a = new long[a.Length];
        List<int>[] list = new List<int>[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            list[i] = new List<int>();
            long_a[i] = a[i];
        }

        for (int i = 0; i < edges.GetLength(0); i++)
        {
            list[edges[i, 0]].Add(edges[i, 1]);
            list[edges[i, 1]].Add(edges[i, 0]);
        }

        dfs(0, visited, a, list);

        return answer;
    }

    public long dfs(int now, bool[] visited, int[] a, List<int>[] list)
    {
        visited[now] = true;

        for (int i = 0; i < list[now].Count(); i++)
        {
            if (!visited[list[now][i]])
            {
                long_a[now] += dfs(list[now][i], visited, a, list);
            }
        }

        if (a[now] == 0) return 0;

        answer += Math.Abs(long_a[now]);

        return long_a[now];
    }
}