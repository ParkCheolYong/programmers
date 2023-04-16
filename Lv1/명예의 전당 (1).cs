using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            list.Add(score[i]);

            answer[i] = list.OrderByDescending(x => x).Take(k).Last();
        }

        return answer;
    }
}