using System;

public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
        int[] answer = new int[s.Length] ;
        
        

            for (int i = 0; i < s.Length; i++)
            {
                answer[s.Length - i - 1] = int.Parse(s[i].ToString());
            }
        
        return answer;
    }
}