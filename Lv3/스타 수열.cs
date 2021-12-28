using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] a)
    {
        int answer = 0;

        int[] temp = new int[a.Length + 1];

        for (int i = 0; i < a.Length; i++)
        {
            temp[a[i]]++;
        }

        var keyValuePairs = temp.Select((x, y) => new KeyValuePair<int, int>(y, x)).Where(x => x.Value > 0).OrderBy(x => x.Value);

        foreach (var k in keyValuePairs)
        {
            if (k.Value * 2 <= answer) continue;

            int length = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    if (a[i] == k.Key || a[i + 1] == k.Key)
                    {
                        length += 2;
                        i++;
                    }
                }
            }

            if (answer < length) answer = length;
        }

        return answer;
    }
}