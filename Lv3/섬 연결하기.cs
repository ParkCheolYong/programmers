using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[,] costs)
    {
        int answer = 0;

        List<int[]> list = new List<int[]>();

        for (int i = 0; i < costs.GetLength(0); i++)
        {
            list.Add(new int[] { costs[i, 0], costs[i, 1], costs[i, 2] });
        }

        list.Sort((x,y) => x[2] > y[2] ? 1 : -1);

        int[] root = new int[n];

        for (int i = 0; i < n; i++)
        {
            root[i] = i;
        }

        foreach (int[] node in list)
        {
            int x = find(root, node[0]);
            int y = find(root, node[1]);

            if (x == y) continue;
            else
            {
                answer += node[2];
                union(root, x, y);
            }
        }

        return answer;
    }

    public int find(int[] root, int x)
    {
        if (root[x] == x)
        {
            return x;
        }
        else
        {
            return root[x] = find(root, root[x]);
        }
    }

    public void union(int[] root, int x, int y)
    {
        if (x < y) root[y] = x;
        else root[x] = y;
    }
}