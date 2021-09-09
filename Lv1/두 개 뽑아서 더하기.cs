using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        List<int> listNum = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                listNum.Add(numbers[i] + numbers[j]);
            }
        }

        int[] answer = new int[listNum.Distinct().Count()];

        answer = listNum.Distinct().ToArray();

        Array.Sort(answer);

        return answer;
    }
}