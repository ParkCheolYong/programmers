using System;

public class Solution 
{
    public int[] solution(string s)
    {
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            int idx = s.Substring(0, i).LastIndexOf(s[i]);
            answer[i] = idx == -1 ? -1 : i - idx;
        }

        return answer;
    }
}