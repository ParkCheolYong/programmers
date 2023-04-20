using System;

public class Solution 
{
    public int[] solution(int[] prices) 
    {
        int[] answer = new int[prices.Length];

        for (int i = 0; i < prices.Length - 1; i++)
        {
            int sec = 0;

            for (int j = i + 1; j < prices.Length; j++)
            {
                sec++;

                if (prices[i] > prices[j])
                {
                    break;
                }
            }

            answer[i] = sec;
        }

        return answer;
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];
        Stack<int> stack = new Stack<int>();
        int i = 0;
        stack.Push(i);
        for (i = 1; i < prices.Length; i++)
        {
            while(stack.Count() != 0 && prices[i] < prices[stack.Peek()])
            {
                int beginIdx = stack.Pop();
                answer[beginIdx] = i - beginIdx;
            }
            stack.Push(i);
        }

        while(stack.Count() != 0)
        {
            int beginIdx = stack.Pop();
            answer[beginIdx] = i - beginIdx - 1;
        }

        return answer;
    }
}*/
