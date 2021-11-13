using System;

public class Solution {
    public int[] solution(int[] prices) {
        int[] answer = new int[prices.Length];

            for (int i = 0; i < prices.Length - 1; i++)
            {
                int sec = 0;

                for (int j = i + 1; j < prices.Length; j++)
                {
                    sec++;

                    if (prices[i] > prices[j])
                    {
                        break;
                    }
                }

                answer[i] = sec;
            }

            return answer;
    }
}