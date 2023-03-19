using System;

public class Solution 
{
    public int solution(string[,] book_time)
    {
        int answer = 0;
        int[] time = new int[(24 * 60) + 10];

        for (int i = 0; i < book_time.GetLength(0); i++)
        {
            //입실
            time[ParseMinute(book_time[i, 0])] += 1;
            //퇴실 + 청소
            time[ParseMinute(book_time[i, 1]) + 10] += -1;
        }
        
        for (int i = 1; i < time.Length; i++)
        {
            time[i] += time[i - 1];
            answer = Math.Max(answer, time[i]);
        }

        return answer;
    }

    public int ParseMinute(string time)
    {
        string[] timeSplit = time.Split(':');
        int hour = int.Parse(timeSplit[0]) * 60;
        int minute = int.Parse(timeSplit[1]);

        return hour + minute;
    }
}