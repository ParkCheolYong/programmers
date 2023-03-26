public class Solution 
{
    public long solution(int n)
    {
        long[] num = new long[n];

        num[0] = 1;
        if (n > 1)  num[1] = 2;

        for (int i = 2; i < n; i++)
        {
            num[i] = (num[i - 2] + num[i - 1]) % 1234567; 
        }

        return num[n - 1];
    }
}