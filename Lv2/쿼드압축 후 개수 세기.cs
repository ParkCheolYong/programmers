using System;

public class Solution 
{
    int[] answer = new int[2];

    public int[] solution(int[,] arr) 
    {
        QuadZip(arr, 0, 0, arr.GetLength(0));

        return answer;
    }

    public void QuadZip(int[,] arr, int x, int y, int s)
    {
        int firstNum = arr[x, y];

        for (int i = x; i < x + s; i++)
        {
            for (int j = y; j < y + s; j++)
            {
                if (firstNum != arr[i,j])
                {
                    QuadZip(arr, x, y, s / 2);
                    QuadZip(arr, x + s / 2, y, s / 2);
                    QuadZip(arr, x, y + s / 2, s / 2);
                    QuadZip(arr, x + s / 2, y + s / 2, s / 2);

                    return;
                }
            }
        }

        answer[firstNum]++;
    }
}