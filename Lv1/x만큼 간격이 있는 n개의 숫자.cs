using System.Collections.Generic;

public class Solution 
{
    public long[] solution(int x, int n) 
    {
        List<long> list = new List<long>();
        long num = 0;

        for (int i = 0; i < n; i++)
        {
            num += x;
            list.Add(num);
        }

        return list.ToArray();
    }
}