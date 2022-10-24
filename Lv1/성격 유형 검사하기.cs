using System;
using System.Collections.Generic;
using System.Text;

public class Solution 
{
    public string solution(string[] survey, int[] choices) 
    {
        string answer = "";

        Dictionary<char, int> dic = new Dictionary<char, int>() 
        {
            {'R', 0}, {'T', 0},
            {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0},
            {'A', 0}, {'N', 0}
        };
            
        for (int i = 0; i < survey.Length; i++)
        {
            if (choices[i] <= 3)
            {
                dic[survey[i][0]] += (4 - choices[i]);
            }
            else if (choices[i] >= 5)
            {
                dic[survey[i][1]] += (choices[i] - 4);
            }
        }

        answer = new StringBuilder().Append(dic['R'] >= dic['T'] ? 'R' : 'T')
                                    .Append(dic['C'] >= dic['F'] ? 'C' : 'F')
                                    .Append(dic['J'] >= dic['M'] ? 'J' : 'M')
                                    .Append(dic['A'] >= dic['N'] ? 'A' : 'N').ToString();        
        
        return answer;
    }
}