public class Solution {
    public int solution(int[] arr) {
        int gcd = GetGcd(arr[0], arr[1]);
            int lcm = arr[0] * arr[1] / gcd;

            for (int i = 2; i < arr.Length; i++)
            {
                gcd = GetGcd(lcm, arr[i]);
                lcm = lcm * arr[i] / gcd;
            }

            return lcm;
    }

    public int GetGcd(int a, int b)
        {
            return a % b == 0 ? b : GetGcd(b, a % b);
        }
}