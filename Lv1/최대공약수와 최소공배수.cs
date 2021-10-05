public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];

        int gcd = GetGcd(n, m);

        answer[0] = gcd;
        answer[1] = n * m / gcd;

        return answer;
    }
    
    public int GetGcd(int a, int b)
    {
        return a % b == 0 ? b : GetGcd(b, a % b);
    }
}