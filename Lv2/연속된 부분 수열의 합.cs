using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] sequence, int k)
    {
        List<Tuple<int, int, int>> list = new List<Tuple<int, int, int>>();
        int start = 0;
        int end = 0;
        int sum = sequence[0];

        while (start < sequence.Length)
        {
            if (sum == k)
            {
                list.Add(new Tuple<int, int, int>(end - start, start, end));
                sum -= sequence[start++];
            }
            else if (sum > k)
            {
                sum -= sequence[start++];
            }
            else
            {
                if (end == sequence.Length - 1)
                {
                    sum -= sequence[start++];
                }
                else
                {
                    sum += sequence[++end];
                }
            }
        }

        Tuple<int, int, int> temp = list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).First();

        return new int[] { temp.Item2, temp.Item3 };
    }
}