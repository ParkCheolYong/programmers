using System;

public class Solution 
{
public int solution(string[] board)
    {
        int o = 0;
        int x = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] == 'O') o++;
                else if (board[i][j] == 'X') x++;
            }
        }

        if (o - x < 0 || o - x > 1) return 0;

        if (o >= 3)
        {
            if (IsEnd(board,'O'))
            {
                if (IsEnd(board, 'X')) return 0;

                if (o - x == 1) return 1; 
                else return 0;
            }
        }

        if (x >= 3)
        {
            if (IsEnd(board, 'X'))
            { 
                if (o - x == 0) return 1;
                else return 0;
            }
        }

        return 1;
    }

    public bool IsEnd(string[] board, char sign)
    {
        //가로 확인
        for (int i = 0; i < 3; i++)
        {
            bool flag = true;

            for (int j = 0; j < 3; j++)
            {
                if (board[i][j] != sign)
                {
                    flag = false;
                }
            }

            if (flag) return true;
        }

        //세로 확인
        for (int i = 0; i < 3; i++)
        {
            bool flag = true;

            for (int j = 0; j < 3; j++)
            {
                if (board[j][i] != sign)
                {
                    flag = false;
                }
            }

            if (flag) return true;
        }

        //대각 확인
        if (board[0][0] == sign && board[1][1] == sign && board[2][2] == sign) return true;
        if (board[0][2] == sign && board[1][1] == sign && board[2][0] == sign) return true;

        return false;
    }
}