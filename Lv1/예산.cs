using System;

public class Solution 
{
    public int solution(int[] d, int budget) 
    {
        int answer = 0;
        int sum = 0;
        Array.Sort(d);
        
        if (d.Length == 1)
        {
            if (d[0] <= budget) return 1;
            else return 0;
        }

        for (int i = 0; i < d.Length; i++)
        {
            sum += d[i];

            if (sum == budget)
            {
                answer = i + 1;
                break;
            }
            else if (sum > budget)
            {
                answer = i;
                break;
            }
        }

        if (answer == 0) answer = d.Length;
        
        return answer;
    }
}