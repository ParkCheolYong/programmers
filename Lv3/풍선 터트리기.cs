using System;

public class Solution {
    public int solution(int[] a)
    {
        int answer = a.Length;

        int[] leftArr = new int[a.Length];
        int[] rightArr = new int[a.Length];

        leftArr[0] = a[0];
        rightArr[a.Length - 1] = a[a.Length - 1];

        for (int i = 1; i < a.Length; i++)
        {
            leftArr[i] = a[i] > leftArr[i - 1] ? leftArr[i - 1] : a[i];
        }

        for (int i = a.Length - 2; i > 0; i--)
        {
            rightArr[i] = a[i] > rightArr[i + 1] ? rightArr[i + 1] : a[i];
        }

        for (int i = 1; i < a.Length - 1; i++)
        {
            if (a[i] > leftArr[i - 1] && a[i] > rightArr[i + 1]) answer--;
        }

        return answer;
    }
}