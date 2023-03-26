using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[] priorities, int location)
    {
        int answer = 0;

        Queue<KeyValuePair<int,int>> q = new Queue<KeyValuePair<int,int>>();

        for (int i = 0; i < priorities.Length; i++)
        {
            q.Enqueue(new KeyValuePair<int,int>(i, priorities[i]));
        }

        KeyValuePair<int, int> temp;

        while (q.Count() > 0)
        {
            temp = q.Dequeue();

            if (q.Count() > 0 && q.Max(x => x.Value) > temp.Value)
            {
                q.Enqueue(temp);
            }
            else
            {
                answer++;

                if (temp.Key == location) break;
            }
        }

        return answer;
    }
}
