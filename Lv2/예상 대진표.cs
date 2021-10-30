using System;

class Solution
{
    public int solution(int n, int a, int b)
        {
            int answer = 1;

            for (int i = 2; i <= n; i *= 2)
            {
                if (b - a == 1)
                {
                    if (a % 2 == 1) return answer;
                }
                else if (a - b == 1)
                {
                    if (b % 2 == 1) return answer;
                }

                a = (int)Math.Ceiling(a / 2.0);
                b = (int)Math.Ceiling(b / 2.0);

                answer++;
            }

            return answer;
        }
}