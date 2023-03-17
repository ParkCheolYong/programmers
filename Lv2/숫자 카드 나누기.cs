using System;

public class Solution 
{
    public int solution(int[] arrayA, int[] arrayB)
    {
        int answer = 0;

        int gcd1 = GetGcd(arrayA);
        int gcd2 = GetGcd(arrayB);

        gcd1 = GcdCheck(gcd1, arrayB);
        gcd2 = GcdCheck(gcd2, arrayA);

        return Math.Max(gcd1,gcd2);
    }

    public int GcdCheck(int a, int[] arrayA)
    {
        if (a == 1) return 0;

        for (int i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] % a == 0)
            {
                return 0;
            }
        }

        return a;
    }

    public int GetGcd(int[] arrayA)
    {
        int gcd = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            gcd = Gcd(gcd, arrayA[i]);
        }

        return gcd;
    }

    public int Gcd(int a, int b)
    {
        return a % b == 0 ? b : Gcd(b, a % b);
    }
}