using System;
using System.Linq;

public class Solution 
{
    public int[] solution(string s) 
    {
        int[] answer = new int[2];
        int length = 0;

        while (length != 1)
        {
            answer[1] += s.Where(x => x == '0').Count();
            length = s.Where(x => x == '1').Count();

            s = Convert.ToString(length, 2);

            answer[0]++;
        }

        return answer;
    }
}