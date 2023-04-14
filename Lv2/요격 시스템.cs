using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[,] targets)
    {
        int answer = 0;

        List<int[]> list = new List<int[]>();

        for (int i = 0; i < targets.GetLength(0); i++)
        {
            list.Add(new int[] { targets[i, 0], targets[i, 1] });
        }

        list = list.OrderBy(x => x[0]).ToList();

        int e = 0;
        int nextS = 0;
        int nextE = 0;

        for (int i = 0; i < list.Count(); i++)
        {
            nextS = list[i][0];
            nextE = list[i][1];

            if (e <= nextS)
            {
                answer++;
                e = nextE;
            }
            else
            {
                e = Math.Min(e, nextE);
            }
        }

        return answer;
    }
}