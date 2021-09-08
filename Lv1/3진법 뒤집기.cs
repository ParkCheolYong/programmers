using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int n) 
    {
        List<int> list = new List<int>();
        while (n != 0)
        {
            list.Add(n % 3);
            n /= 3;
        }

        list.Reverse();

        return (int)list.Select((x, idx) => x * Math.Pow(3, idx)).Sum();
    }
}