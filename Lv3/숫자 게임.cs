using System;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B)
    {
        int answer = 0;

        A = A.OrderByDescending(x => x).ToArray();
        B = B.OrderByDescending(x => x).ToArray();

        int idx = 0;

        for (int i = 0; i < A.Length; i++)
        {

            for (int j = idx; j < B.Length; j++)
            {
                if (A[i] < B[j])
                {
                    idx++;
                    answer++;
                    break;
                }
                else 
                {
                    break;
                }
            }
        }

        return answer;
    }
}