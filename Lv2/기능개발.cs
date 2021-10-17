using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        Queue<int> q = new Queue<int>(progresses);
        Queue<int> q2 = new Queue<int>(speeds);
            List<int> answer = new List<int>();

            while (q.Count > 0)
            {
                int cnt = 0;

                for (int i = 0; i < q.Count; i++)
                {
                    int progress = q.Dequeue();
                    progress += q2.ElementAt(i);
                    q.Enqueue(progress);
                }

                while (q.Count > 0)
                { 
                    if (q.Peek() >= 100)
                    {
                        q.Dequeue();
                        q2.Dequeue();
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (cnt != 0) answer.Add(cnt);
            }

            return answer.ToArray();
    }
}