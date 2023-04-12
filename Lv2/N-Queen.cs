using System;

public class Solution 
{
    private int[] board;
    private int answer = 0;

    public int solution(int n)
    {
        board = new int[n];

        BackTracking(0, n);

        return answer;
    }

    public void BackTracking(int depth, int n)
    {
        if (depth == n)
        {
            answer++;
            return;
        }

        for (int i = 0; i < n; i++)
        {
            board[depth] = i;
            if (Validate(depth))
            {
                BackTracking(depth + 1, n);
            }
        }
    }

    public bool Validate(int i)
    {
        for (int j = 0; j < i; j++)
        {
            if (board[i] == board[j]) return false;

            if(Math.Abs(i-j) == Math.Abs(board[i] - board[j])) return false;
        }

        return true;
    }
}