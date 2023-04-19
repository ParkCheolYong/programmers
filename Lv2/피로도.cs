using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    List<int> list = new List<int>();
    
    public int solution(int k, int[,] dungeons)
    {
        bool[] visited = new bool[dungeons.GetLength(0)];

        DFS(0, k,dungeons,visited);

        return list.Max();
    }

    public void DFS(int cnt, int k, int[,] dungeons, bool[] visited)
    {
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (!visited[i])
            {
                if(k >= dungeons[i,0])
                {
                    k -= dungeons[i, 1];
                    visited[i] = true;
                    cnt++;
                    list.Add(cnt);
                    DFS(cnt, k, dungeons, visited);
                    k += dungeons[i, 1];
                    cnt--;
                    visited[i] = false;
                }
            }
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    HashSet<int> hs;

    public int solution(int k, int[,] dungeons) 
    {
        hs = new HashSet<int>();

        List<Tuple<int, int>> arr = new List<Tuple<int, int>>();
        List<Tuple<int, int>> list = new List<Tuple<int, int>>();

        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            arr.Add(new Tuple<int, int>(dungeons[i, 0], dungeons[i, 1]));
        }

        for (int i = 0; i < arr.Count; i++)
        {
            dungeonsCount(arr, list, arr.Count, i + 1, k);
        }

        return hs.Max();
    }

    public void dungeonsCount(List<Tuple<int, int>> arr, List<Tuple<int, int>> list, int n, int r, int k)
    {
        if (r == 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (k >= list[i].Item1)
                {
                    k -= list[i].Item2;
                }
                else
                {
                    return;
                }
            }

            hs.Add(list.Count);
        }

        for (int i = 0; i < n; i++)
        {
            list.Add(arr[i]);
            arr.RemoveAt(i);

            dungeonsCount(arr, list, n - 1, r - 1, k);

            arr.Insert(i, list[list.Count - 1]);
            list.RemoveAt(list.Count - 1);
        }
    }
}*/
