using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {

                for (int k = 0; k < arr2.GetLength(1); k++)
                {
                    int a = 0;

                    for (int j = 0; j < arr2.GetLength(0); j++)
                    {
                        a += (arr1[i, j] * arr2[j, k]);
                    }

                    answer[i, k] = a;
                }
            }

            return answer;
    }
}