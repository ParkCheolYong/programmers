using System;
using System.Linq;
using System.Text;

public class Solution 
{
    public string solution(int[] food)
    {
        string answer = "";

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i < food.Length; i++)
        {
            int repeat = food[i] / 2;

            sb.Insert(sb.Length, i.ToString(),repeat);
        }

        answer = sb.ToString() + "0" + string.Join("", sb.ToString().Reverse());

        return answer;
    }
}