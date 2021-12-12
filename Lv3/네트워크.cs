using System;

public class Solution {
    public int solution(int n, int[,] computers)
        {
            int answer = 0;
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;

                    if (dfs(i, n, computers, visited))  answer++;
                }
            }

            return answer;
        }

        public bool dfs(int i, int n, int[,] computers, bool[] visited)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;
                if (!visited[j] && computers[i,j] == 1)
                {
                    visited[j] = true;
                    dfs(j, n, computers, visited);
                }
            }

            return true;
        }
}