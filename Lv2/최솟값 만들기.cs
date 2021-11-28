using System;
using System.Linq;

public class Solution {
    public int solution(int[] A, int[] B) 
    {
        A = A.OrderBy(x => x).ToArray();
        B = B.OrderByDescending(x => x).ToArray();

        return A.Select((x, idx) => A[idx] * B[idx]).Sum();
    }
}