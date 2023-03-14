using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[] queue1, int[] queue2)
    {
        int answer = 0;      
        long sum1 = 0;
        long sum2 = 0;
        int dequeue = 0;
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        for (int i = 0; i < queue1.Length; i++)
        {
            sum1 += queue1[i];
            sum2 += queue2[i];
            q1.Enqueue(queue1[i]);
            q2.Enqueue(queue2[i]);
        }

        long targetNum = (sum1 + sum2) / 2;
        int maxCnt = queue1.Length * 4;

        if ((sum1 + sum2) % 2 == 1) return -1;

        while (sum1 != targetNum)
        {
            if (sum1 < targetNum)
            {
                if (q2.Count > 0)
                {
                    dequeue = q2.Dequeue();
                    q1.Enqueue(dequeue);
                    sum1 += dequeue;
                    sum2 -= dequeue;
                    answer++;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (q1.Count > 0)
                {
                    dequeue = q1.Dequeue();
                    q2.Enqueue(dequeue);
                    sum1 -= dequeue;
                    sum2 += dequeue;
                    answer++;
                }
                else
                {
                    return -1;
                }
            }

            if (answer == maxCnt) return -1;
        }

        return answer;
    }
}