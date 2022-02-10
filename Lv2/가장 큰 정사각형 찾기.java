class Solution
{
    public int solution(int [][]board)
    {
        if (board.length <= 1 || board[0].length <= 1) return 1;
        
        int max = 0;
        for (int i = 1; i < board.length; i++)
        {
        	for (int j = 1; j < board[i].length; j++)
        	{
        		if (board[i][j] >= 1)
        		{
        			int top = board[i - 1][j];
        			int left = board[i][j - 1];
        			int topLeft = board[i - 1][j - 1];
        		
        			board[i][j] = (Math.min(top, Math.min(left, topLeft))) + 1;
        			if (board[i][j] > max)
        			{
        				max = board[i][j];
        			}
        		}
        	}
        }

        return max * max;
    }
}