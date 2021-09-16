using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] { };
            List<int> answerList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    answerList.Add(arr[i]);
                }
            }
            if (answerList.Count == 0)
                answerList.Add(-1);

            answer = answerList.ToArray();
        
            Array.Sort(answer);
        
            return answer;
    }
}