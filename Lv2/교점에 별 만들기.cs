using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string[] solution(int[,] line)
    {
        List<int[]> list = new List<int[]>();

        for (int i = 0; i < line.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < line.GetLength(0); j++)
            {
                long A = line[i, 0];
                long B = line[i, 1];
                long E = line[i, 2];
                long C = line[j, 0];
                long D = line[j, 1];
                long F = line[j, 2];

                long c = (A * D) - (B * C);
                if (c == 0) continue;

                long a = (B * F) - (E * D);
                long b = (E * C) - (A * F);
                if (a % c != 0 || b % c != 0) continue;

                int x = (int)(a / c); 
                int y = (int)(b / c);

                list.Add(new int[2] { y, x });
            }
        }

        int maxY = list.Max(z => z[0]);
        int maxX = list.Max(z => z[1]);
        int minY = list.Min(z => z[0]);
        int minX = list.Min(z => z[1]);

        int pointX = maxX - minX;
        int pointY = maxY - minY;

        int[,] coordinate = new int[pointY + 1, pointX + 1];

        for (int i = 0; i < list.Count(); i++)
        {
            coordinate[Math.Abs(list[i][0] + (-minY) - pointY), list[i][1] + (-minX)] = 1;
        }

        List<string> listAnswer = new List<string>();

        for (int i = 0; i < coordinate.GetLength(0); i++)
        {
            StringBuilder sb = new StringBuilder();

            for(int j = 0; j < coordinate.GetLength(1); j++)
            {
                if (coordinate[i,j] == 1)   
                    sb.Append("*");
                else    
                    sb.Append(".");
            }

            listAnswer.Add(sb.ToString());
        }

        return listAnswer.ToArray();
    }
}