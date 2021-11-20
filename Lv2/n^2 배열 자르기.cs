using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[] {};

        List<int> list = new List<int>();

        long idx = 0;

        for (int i = 1; i <= n; i++)
        {
            if (idx + n < left)
            {
                idx += n;
                continue;
            }

            for (int j = 1; j <= n; j++)
            {
                if (idx >= left && idx <= right)
                {
                    if (i >= j) list.Add(i);
                    else list.Add(j);
                }

                idx++;

                if (idx > right) return list.ToArray();
            }
        }

        return answer;
    }
}