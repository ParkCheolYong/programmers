using System;

class Solution
{
    public int solution(int n, int[] stations, int w)
    {
        int answer = 0;
        int begin = 1;
        int end = 0;

        foreach(int i in stations) 
        {
            end = i - w;

            if (begin < end)
            {
                answer += (end - begin - 1) / (2 * w + 1) + 1;
            }

            begin = i + w + 1;
        }

        if (begin <= n)
        {
            answer += (n - begin) / (2 * w + 1) + 1;
        }

        return answer;
    }
}