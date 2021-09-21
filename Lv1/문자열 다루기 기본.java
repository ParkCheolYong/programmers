using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;

            for (int i = 0; i < s.Length; i++)
            {
                if((s.Length == 4 || s.Length == 6) && ((int)s[i] > 64 && (int)s[i] < 123))
                {
                    answer = false;
                    break;
                }
                else
                {
                    answer = true;
                    break;
                }
            }
            return answer;
    }
}