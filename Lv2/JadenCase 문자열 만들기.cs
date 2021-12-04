using System.Linq;

public class Solution {
    public string solution(string s) 
    {
        return string.Join("", s.ToLower().Select((x, idx) => idx == 0 ? x.ToString().ToUpper() : s[idx - 1] == ' ' ? x.ToString().ToUpper() : x.ToString()));
    }
}