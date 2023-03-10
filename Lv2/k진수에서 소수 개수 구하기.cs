using System;

public class Solution {
    public int solution(int n, int k)
    {
        int answer = 0;
        string strNum = "";

        while (n > 0)
        {
            strNum = (n % k) + strNum;
            n /= k;
        }

        string[] primeNum = strNum.Split('0');

        for (int i = 0; i < primeNum.Length; i++)
        {
            if (primeNum[i] == "") continue;

            if (isPrime(long.Parse(primeNum[i])))
            {
                answer++;
            }
        }

        return answer;
    }
    
    public bool isPrime(long num)
    {
        if (num <= 1) return false;
        else if (num == 2) return true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }

        return true;
    }    
}