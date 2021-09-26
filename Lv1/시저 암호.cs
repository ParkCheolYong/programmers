using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] != ' ')
                {

                    int change = (int)s[i] + n;

                    if (char.IsUpper(s[i]) && change > 90)
                    {
                        change -= 26;
                    }
                    else if (change > 122)
                    {
                        change -= 26;
                    }
                    
                    answer += Convert.ToChar(change);
                    
                }
                else
                {
                    answer += ' ';
                }
            }
        return answer;
    }
}