using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int[,] data, int col, int row_begin, int row_end)
    {
        int answer = 0;

        List<int[]> dataList = new List<int[]>();

        for (int i = 0; i < data.GetLength(0); i++)
        {
            int[] temp = new int[data.GetLength(1)];

            for (int j = 0; j < temp.Length; j++)
            {
                temp[j] = data[i, j];
            }

            dataList.Add(temp);
        }

        dataList = dataList.OrderBy(x => x[col - 1]).ThenByDescending(x => x[0]).ToList();

        for (int i = row_begin - 1; i < row_end; i++)
        {
            int sum = 0;

            for (int j = 0; j < data.GetLength(1); j++)
            {
                sum += dataList[i][j] % (i + 1);
            }

            answer = answer ^ sum;
        }

        return answer;
    }
}