using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        Queue<int> progressesQ = new Queue<int>(progresses);
        Queue<int> speedsQ = new Queue<int>(speeds);        
        List<int> answerList = new List<int>();

        while (progressesQ.Count() > 0)
        {
            int cnt = 0;

            for (int i = 0; i < progressesQ.Count(); i++)
            {
                progressesQ.Enqueue(progressesQ.Dequeue() + speedsQ.ElementAt(i));
            }

            while (progressesQ.Count() > 0)
            {
                if (progressesQ.Peek() >= 100)
                {
                    progressesQ.Dequeue();
                    speedsQ.Dequeue();
                    cnt++;
                }
                else
                {
                    break;
                }
            }

            if (cnt > 0) answerList.Add(cnt);
        }

        return answerList.ToArray();
    }
}
