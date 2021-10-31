using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;

            Queue<char> q = new Queue<char>();
            foreach (char c in s.ToCharArray())
            {
                q.Enqueue(c);
            }

            for (int x =0; x < s.Length; x++)
            {
                if (q.Peek() == ']' || q.Peek() == '}' || q.Peek() == ')')
                {
                    q.Enqueue(q.Dequeue());
                    continue;
                }

                string rotation = string.Join("", q);
                string temp = rotation;
                while(true)
                {
                    temp = rotation.Replace("[]", "").Replace("{}", "").Replace("()", "");

                    if (temp != rotation)
                    {
                        rotation = temp;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(temp))
                        {
                            answer++;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                q.Enqueue(q.Dequeue());
            }

            return answer;
    }
}