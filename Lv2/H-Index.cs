using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] citations) 
    {
        int[] temp = citations.Where(x => x != 0).OrderByDescending(z => z).ToArray();

        if (temp.Count() == 0) return 0;

        for (int i = 1; i <= temp.Length; i++)
        {
            if (i == temp[i - 1])
            {
                return i;
            }
            else if (i > temp[i - 1])
            {
                return i - 1;
            }
        }

        return temp.Length;
    }
}