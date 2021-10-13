class Solution {
    public long solution(int w, int h) {

        long w1 = w;
        long h1 = h;

        long answer = w1 * h1;

        long gcd = GetGcd(w1,h1);        

        w1 /= gcd;
        h1 /= gcd;

        long x = 0;

        x = w1 + h1 - 1;

        return answer - (x * gcd);        
    }

    public long GetGcd(long a, long b)
    {
        return a % b == 0 ? b : GetGcd(b , a % b);
    }
}