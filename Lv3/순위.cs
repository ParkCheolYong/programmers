using System;

public class Solution {
    public int solution(int n, int[,] results)
    {
        int answer = 0;

        bool[,] D = new bool[n + 1, n + 1];

        for (int i = 0; i < results.GetLength(0); i++)
        {
            D[results[i, 0], results[i, 1]] = true;
        }

        for (int k = 1; k <= n; k++)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == k) continue;

                for (int j = 1; j <= n; j++)
                {
                    if (i == j || k == j) continue;

                    if (D[i,k] && D[k,j])
                    {
                        D[i, j] = true;
                    }
                }
            }
        }

        for (int i = 1; i <= n; i++)
        {
            int cnt = 0;

            for (int j = 1; j <= n; j++)
            {
                if (i == j) continue;

                if (D[i, j] || D[j, i]) cnt++;
            }

            if (cnt == n - 1) answer++;
        }

        return answer;
    }
}