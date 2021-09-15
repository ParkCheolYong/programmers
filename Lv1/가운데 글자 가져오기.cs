public class Solution {
    public string solution(string s) {
        string answer = "";
            int lengthHalf = s.Length / 2;

            if (s.Length % 2 == 0)
            {
                answer = string.Format("{0}{1}", s[lengthHalf - 1], s[lengthHalf]);
            }
            else
            {
                answer += s[lengthHalf];
            }


            return answer;
    }
}