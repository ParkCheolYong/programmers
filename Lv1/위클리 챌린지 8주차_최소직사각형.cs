using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] sizes)
        {
            List<int[]> list = new List<int[]>();

            for(int i = 0; i < sizes.GetLength(0); i++)
            {
                int temp = 0;

                if (sizes[i,0] < sizes[i,1])
                {
                    temp = sizes[i, 1];
                    sizes[i, 1] = sizes[i, 0];
                    sizes[i, 0] = temp;
                }

                list.Add(new int[2] { sizes[i, 0], sizes[i, 1] });
            }

            return list.Max(x => x[0]) * list.Max(x => x[1]);
        }
}