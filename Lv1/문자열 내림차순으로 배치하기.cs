using System;
public class Solution {
    public string solution(string s) {
        string answer = "";

            char[] arr = s.ToCharArray();

            Array.Sort(arr);
            Array.Reverse(arr);

            answer = new string(arr);
        return answer;
    }
}