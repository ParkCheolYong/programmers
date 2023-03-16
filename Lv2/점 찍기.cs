using System;

public class Solution 
{
    public long solution(int k, int d)
    {
        long answer = 0;
        double distance = 0;

        for (int x = 0; x <= d; x+=k)
        {
            distance = Math.Sqrt(Math.Pow(d, 2) - Math.Pow(x, 2));

            answer += (long)Math.Ceiling(distance / k) + (distance % k == 0 ? 1 : 0);
        }

        return answer;
    }
}