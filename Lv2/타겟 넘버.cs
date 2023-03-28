using System;

public class Solution 
{
    public int solution(int[] numbers, int target) 
    {
        return DFS(numbers, target, 0, 0);
    }
    
    public int DFS(int[] numbers, int target, int i, int sum)
    {
        if (i == numbers.Length)
        {                        
            if (sum == target) return 1;
            else return 0;
        }
        else
        {
            return DFS(numbers, target, i + 1, sum + numbers[i]) + DFS(numbers, target, i + 1, sum - numbers[i]);                
        }        
    }
}
