using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;

        Dictionary<string,int> dic = new Dictionary<string,int>();

        for (int i = 0; i < want.Length; i++)
        {
            dic.Add(want[i], number[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            if (dic.ContainsKey(discount[i]))
            {
                dic[discount[i]]--;
            }
        }

        if (dic.Where(x => x.Value > 0).Count() == 0) answer++;

        for (int i = 0; i < discount.Length - 10; i++)
        {
            if (dic.ContainsKey(discount[i]))
            {
                dic[discount[i]]++;
            }

            if (dic.ContainsKey(discount[i + 10]))
            {
                dic[discount[i + 10]]--;
            }

            if (dic.Where(x => x.Value > 0).Count() == 0) answer++;
        }

        return answer;
    }
}