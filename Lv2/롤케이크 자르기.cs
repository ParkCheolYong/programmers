using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] topping) 
    {
        int answer = 0;

        Dictionary<int, int> dicChulSu = new Dictionary<int, int>() { { topping[0], 1 } };
        Dictionary<int, int> dicBrother = new Dictionary<int, int>();

        for (int i = 1; i < topping.Length; i++)
        {
            if (dicBrother.ContainsKey(topping[i]))
            {
                dicBrother[topping[i]]++;
            }
            else
            {
                dicBrother.Add(topping[i], 1);
            }
        }

        for (int i = 1; i < topping.Length; i++)
        {
            if (dicChulSu.ContainsKey(topping[i]))
            {
                dicChulSu[topping[i]]++;
            }
            else
            {
                dicChulSu.Add(topping[i], 1);
            }

            dicBrother[topping[i]]--;

            if (dicBrother[topping[i]] == 0) dicBrother.Remove(topping[i]);

            if (dicChulSu.Count() == dicBrother.Count())
            {
                answer++;
            }
            else if (dicChulSu.Count() > dicBrother.Count())
            {
                break;
            }
        }

        return answer;
    }
}