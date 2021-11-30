public class Solution {
    public int solution(int n) {
        return Fibonacci(n);
    }

    public int Fibonacci(int n)
        {
            int c = 0;
            int a = 0;
            int b = 1;

            for (int i = 0; i < n -1; i++)
            {
                c = (a + b) % 1234567;
                a = b;
                b = c;
            }

            return c;
        }
}