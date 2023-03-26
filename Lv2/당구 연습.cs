using System;

public class Solution 
{
    public int[] solution(int m, int n, int startX, int startY, int[,] balls)
    {
        int[] answer = new int[balls.GetLength(0)];

        //대칭점
        int[,] point = new int[,] { { -startX, startY }, { startX, -startY }, { m * 2 - startX, startY }, { startX, n * 2 - startY } };

        for (int i = 0; i < balls.GetLength(0); i++)
        {
            int minDistance = int.MaxValue;

            for (int j = 0; j < point.GetLength(0); j++)
            {
                //x값 같을 때
                if (startX == balls[i,0])
                {
                    if (startY < balls[i,1])
                    {
                        //위 빼고 거리 계산
                        if (j != 3)
                            minDistance = Math.Min(minDistance, (int)(Math.Pow(balls[i, 0] - point[j, 0], 2) + Math.Pow(balls[i, 1] - point[j, 1], 2)));
                    }                        
                    else
                    {
                        // 아래 빼고 거리 계산
                        if (j != 1)
                            minDistance = Math.Min(minDistance, (int)(Math.Pow(balls[i, 0] - point[j, 0], 2) + Math.Pow(balls[i, 1] - point[j, 1], 2)));
                    }
                }
                //y값 같을 때
                else if (startY == balls[i,1])
                {
                    if (startX < balls[i, 0])
                    {
                        //오른쪽 빼고 거리 계산
                        if (j != 2)
                            minDistance = Math.Min(minDistance, (int)(Math.Pow(balls[i, 0] - point[j, 0], 2) + Math.Pow(balls[i, 1] - point[j, 1], 2)));
                    }
                    else
                    {
                        //왼쪽 빼고 거리 계산
                        if (j != 0)
                                minDistance = Math.Min(minDistance, (int)(Math.Pow(balls[i, 0] - point[j, 0], 2) + Math.Pow(balls[i, 1] - point[j, 1], 2)));
                    }
                }
                else
                {
                        minDistance = Math.Min(minDistance, (int)(Math.Pow(balls[i, 0] - point[j, 0], 2) + Math.Pow(balls[i, 1] - point[j, 1], 2)));
                }
            }

            answer[i] = minDistance;
        }

        return answer;
    }
}