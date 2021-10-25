using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[] priorities, int location) 
    {
        int answer = 0;
        List<Tuple<int, int>> list = new List<Tuple<int, int>>();
        Queue q = new Queue();

        for(int i = 0; i < priorities.Length; i++)
        {
            list.Add(new Tuple<int, int>(priorities[i], i));
            q.Enqueue(list[i]);
        }

        while (q.Count > 0)
        {
            list.RemoveAt(0);

            if (list.Any(x => x.Item1 > (q.Peek() as Tuple<int, int>).Item1))
            {
                list.Add((q.Peek() as Tuple<int,int>));
                q.Enqueue(q.Dequeue());
            }
            else
            {
                answer++;

                if (location == (q.Peek() as Tuple<int, int>).Item2)
                {
                    return answer;
                }
                q.Dequeue();
            }
        }

        return answer;
    }
}