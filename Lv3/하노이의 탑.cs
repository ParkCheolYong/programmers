using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    List<int[]> list = new List<int[]>();

    public int[,] solution(int n) {
        hanoi(n, 1, 3, 2);

        int[,] answer = new int[list.Count(),2];

        for (int i = 0; i < list.Count(); i++)
        {
            answer[i, 0] = list[i][0];
            answer[i, 1] = list[i][1];
        }

        return answer;
    }

    public void hanoi(int n, int start, int to, int via)
    {
        if (n == 1)
        {
            list.Add(new int[] { start, to });
        }
        else
        {
            hanoi(n - 1, start, via, to);
            list.Add(new int[] { start, to });
            hanoi(n - 1, via, to, start);
        }
    }
}