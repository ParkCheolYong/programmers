using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int left, int right) 
    {
        List<int> list = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int cnt = 0;

            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0) cnt++;
            }

            cnt++;

            if (cnt % 2 == 0) 
                list.Add(i);
            else
                list.Add(-i);
        }

        return list.Sum();
    }
}