using System;

public class Solution {
    public long solution(long n) {
        double a = Math.Sqrt(n);

            return a % 1 == 0 ? (long)((a + 1) * (a + 1)) : -1 ;
    }
}