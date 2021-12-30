using System;
using System.Linq;

class Solution
{
    public int solution(int[] sticker)
    {
        int answer = 0;

        if (sticker.Length <= 2) return sticker.Max();

        int[] sum = new int[sticker.Length + 1];

        sum[0] = sticker[0];
        sum[1] = sticker[0];

        for (int i = 2; i < sticker.Length - 1; i++)
        {
            sum[i] = Math.Max(sum[i - 2] + sticker[i], sum[i - 1]);
        }

        answer = sum.Max();

        sum = new int[sticker.Length + 1];

        sum[1] = sticker[1];

        for (int i = 2; i < sticker.Length; i++)
        {
            sum[i] = Math.Max(sum[i - 2] + sticker[i], sum[i - 1]);
        }

        return Math.Max(answer, sum.Max());
    }
}