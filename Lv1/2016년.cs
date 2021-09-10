using System;

public class Solution 
{
    public string solution(int a, int b) 
    {
        string answer = "";
            string month = a < 10 ? "0" + a.ToString() : a.ToString();
            string day = b < 10 ? "0" + b.ToString() : b.ToString();

            DateTime dateTime = DateTime.Parse("2016-" + month + "-" + day);

            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday: 
                    answer = "SUN";
                    break;
                case DayOfWeek.Monday:
                    answer = "MON";
                    break;
                case DayOfWeek.Tuesday:
                    answer = "TUE";
                    break;
                case DayOfWeek.Wednesday:
                    answer = "WED";
                    break;
                case DayOfWeek.Thursday:
                    answer = "THU";
                    break;
                case DayOfWeek.Friday:
                    answer = "FRI";
                    break;
                case DayOfWeek.Saturday:
                    answer = "SAT";
                    break;
            }

            return answer;
    }
}