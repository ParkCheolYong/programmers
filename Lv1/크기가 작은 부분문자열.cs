using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string t, string p)
    {
        List<long> list = new List<long>();

        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            list.Add(long.Parse(t.Substring(i, p.Length)));
        }

        return list.Where(x => x <= long.Parse(p)).Count();
    }
}