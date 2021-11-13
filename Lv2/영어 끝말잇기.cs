using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
            Queue<string> q = new Queue<string>();
            List<string> list = new List<string>();
            bool loop = true;

            foreach (string s in words)
            {
                q.Enqueue(s);
            }

            while (loop)
            {
                answer[1]++;

                for (int i = 1; i <= n; i++)
                {
                    if (q.Count == 0)
                    {
                        return new int[] { 0, 0 };
                    }
                    else
                    {
                        if (list.Count == 0)
                        {
                            list.Add(q.Dequeue());
                        }
                        else
                        {
                            if (!list.Contains(q.Peek()) && list[list.Count - 1].Last() == q.Peek().First())
                            {
                                list.Add(q.Dequeue());
                            }
                            else
                            {
                                answer[0] = i;
                                loop = false;
                                break;
                            }
                        }
                    }
                }
            }

            return answer;
    }
}