using System;

public class Solution {
    private int ANSWER = 0;

    public int solution(int[] numbers, int target) {
        //int answer = 0;

        dfs(target, numbers, 0);

        return ANSWER;
    }

    private void dfs(int target, int[] numbers, int k)
        {
            if (k == numbers.Length)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                if (sum == target)
                {
                    ANSWER++;
                }
            }
            else
            {
                dfs(target, numbers, k + 1);

                numbers[k] *= -1;
                dfs(target, numbers, k + 1);
            }
        }
}