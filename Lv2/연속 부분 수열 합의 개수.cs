using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] elements)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 1; i <= elements.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < i; j++)
            {
                sum += elements[j % elements.Length];
            }

            set.Add(sum);

            for (int j = 0; j < elements.Length; j++)
            {
                sum -= elements[j % elements.Length];
                sum += elements[(j + i) % elements.Length];
                set.Add(sum);
            }
        }

        return set.Count();
    }
}