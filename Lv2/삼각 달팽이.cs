using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int maxNumber = Enumerable.Range(1, n).Sum();
            int[] answer = new int[maxNumber];
            int[,] location = new int[n, n];
            int x = -1;
            int y = 0;
            int num = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    num++;

                    //아래
                    if (i % 3 == 0)
                    {
                        x++;  
                    }
                    //오른쪽
                    else if (i % 3 == 1)
                    {
                        y++;
                    }
                    //왼쪽 위
                    else if (i % 3 == 2)
                    {
                        x--;
                        y--;
                    }

                    location[x, y] = num;
                }
            }

            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (location[i, j] == 0) break;

                    answer[idx++] = location[i, j];
                }
            }

            return answer;
    }
}