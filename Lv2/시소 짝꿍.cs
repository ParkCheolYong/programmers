using System;
using System.Collections.Generic;

public class Solution 
{
    public long solution(int[] weights)
    {
        long answer = 0;

        Dictionary<int,int> dicWeights = new Dictionary<int,int>();

        foreach(int w in weights)
        {
            if (dicWeights.ContainsKey(w))
            {
                dicWeights[w]++;
            }
            else
            {
                dicWeights.Add(w, 1);
            }
        }

        foreach(KeyValuePair<int,int> items in dicWeights)
        {
            if (dicWeights[items.Key] > 1)
            {
                answer += (long)items.Value * (items.Value - 1) / 2;
            }

            if (dicWeights.ContainsKey(items.Key * 2))
            {
                answer += (long)items.Value * dicWeights[items.Key * 2];
            }

            if (items.Key * 3 % 2 == 0 
                && dicWeights.ContainsKey(items.Key * 3 / 2))
            {
                answer += (long)items.Value * dicWeights[items.Key * 3 / 2];
            }

            if (items.Key * 4 % 3 == 0
                && dicWeights.ContainsKey(items.Key * 4 / 3))
            {
                answer += (long)items.Value * dicWeights[items.Key * 4 / 3];
            }
        }

        return answer;
    }
}