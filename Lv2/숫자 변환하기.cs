using System;

public class Solution {
    public int solution(int x, int y, int n)
    {
        int[] dp = new int[y + 1];

        Array.Fill(dp, -1);

        dp[x] = 0;

        for (int i = x; i <= y; i++)
        {
            int val = int.MaxValue;

            if (i > n && dp[i - n] != -1)
            {
                val = Math.Min(val, dp[i - n] + 1);
            }

            if (i % 2 == 0 && dp[i / 2] != -1)
            {
                val = Math.Min(val, dp[i / 2] + 1);
            }

            if (i % 3 == 0 && dp[i / 3] != -1)
            {
                val = Math.Min(val, dp[i / 3] + 1);
            }

            if (val != int.MaxValue) dp[i] = val;
        }

        return dp[y];
    }
}