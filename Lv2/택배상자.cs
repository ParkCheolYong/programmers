using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[] order)
    {
        int answer = 0;
        int idx = 0;
        Queue<int> belt = new Queue<int>();
        Stack<int> subBelt = new Stack<int>();

        for (int i = 1; i <= order.Length; i++)
        {
            belt.Enqueue(i);
        }

        while(true)
        {
            if (belt.Count() != 0 && belt.Peek() == order[idx])
            {
                belt.Dequeue();
                idx++;
                answer++;
            }
            else
            {
                if (subBelt.Count() != 0 && subBelt.Peek() == order[idx])
                {
                    subBelt.Pop();
                    idx++;
                    answer++;
                }
                else
                {
                    if (belt.Count() != 0)
                        subBelt.Push(belt.Dequeue());
                    else break;
                }
            }
        }

        return answer;
    }
}