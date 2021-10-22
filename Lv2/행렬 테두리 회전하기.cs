using System;

public class Solution {
    public int[] solution(int rows, int columns, int[,] queries)
        {
            int[] answer = new int[queries.GetLength(0)];
            int[,] numbers = new int[rows, columns];
            int num = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <columns; j++)
                {
                    numbers[i, j] = num++;
                }
            }

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int x1 = queries[i, 0];
                int y1 = queries[i, 1];
                int x2 = queries[i, 2];
                int y2 = queries[i, 3];

                int temp = numbers[x1 - 1, y1 - 1];
                int min = numbers[x1 - 1, y1 - 1];

                //왼쪽 숫자 이동
                for (int j = x1; j < x2; j++)
                {
                    if (min > numbers[j, y1 - 1])
                    {
                        min = numbers[j, y1 - 1];
                    }

                    numbers[j - 1, y1 - 1] = numbers[j, y1 - 1];
                }
                //아래쪽 숫자 이동
                for (int j = y1; j < y2; j++)
                {
                    if (min > numbers[x2 - 1, j])
                    {
                        min = numbers[x2 - 1, j]; 
                    }
                    numbers[x2 - 1, j - 1] = numbers[x2 - 1, j];
                }
                //오른쪽 숫자 이동
                for (int j = x2 - 1 ; j >= x1; j--)
                {
                    if (min > numbers[j - 1, y2 - 1])
                    {
                        min = numbers[j - 1, y2 - 1];
                    }
                    numbers[j, y2 - 1] = numbers[j - 1, y2 - 1];
                }
                //위쪽 숫자 이동
                for (int j = y2 - 1; j >= y1; j--)
                {
                    if (min > numbers[x1 - 1, j - 1])
                    {
                        min = numbers[x1 - 1, j - 1];
                    }
                    numbers[x1 - 1, j] = numbers[x1 - 1, j - 1];
                }

                numbers[x1 - 1, y1] = temp;


                answer[i] = min;
            }

            return answer;
        }
}