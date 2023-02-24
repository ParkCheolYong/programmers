using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        int sum = 0;

        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (int i in tangerine)
        {
            if (dic.ContainsKey(i))
                dic[i] += 1;
            else
                dic.Add(i,1);
        }

        dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

        foreach(int i in dic.Values)
        {
            answer++;
            sum += i;

            if (sum >= k) break;
        }

        return answer;
    }
}