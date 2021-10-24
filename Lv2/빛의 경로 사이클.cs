using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] grid)
    {
        List<int> answer = new List<int>();
        int[,] direction = new int[,] { { 1,0},{ 0,-1},{-1,0 },{ 0,1} };
        int a = grid.Length;
        int b = grid[0].Length;
        bool[,,] visited = new bool[a,b,4];

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int cnt = 0;

                    if (!visited[i,j,k])
                    {
                        while (true)
                        {
                            if (visited[i, j, k]) break;

                            cnt++;
                            visited[i, j, k] = true;

                            if (grid[i][j] == 'L')
                            {
                                k = k == 3 ? 0 : k + 1;
                            }
                            else if (grid[i][j] == 'R')
                            {
                                k = k == 0 ? 3 : k - 1;
                            }

                            i = (i + direction[k, 0] + a) % a;
                            j = (j + direction[k, 1] + b) % b;
                        }

                        answer.Add(cnt);
                    }
                }
            }
        }

        return answer.OrderBy(x => x).ToArray();
    }
}