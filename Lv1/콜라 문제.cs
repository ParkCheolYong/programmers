using System;

public class Solution 
{
    public int solution(int a, int b, int n) 
    {
        int answer = 0;        
        int newBottle = 0;
        int remainBottle = 0;

        while (n >= a)
        {
            newBottle = (n / a) * b;
            remainBottle = n - ((n / a) * a);

            n = newBottle + remainBottle;
            answer += newBottle;
        }
        
        return answer;
    }
}