public class Solution 
{
    public int solution(int[] arr)
    {
        int answer = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            answer = answer * arr[i] / GetGcd(answer, arr[i]);
        }

        return answer;
    }
    
    public int GetGcd(int a, int b)
    {
        return a % b == 0 ? b : GetGcd(b, a % b);
    }
}
