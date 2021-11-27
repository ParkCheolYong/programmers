using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        List<int> list = s.Split(' ').Select(x => int.Parse(x)).ToList();
            int max = list.Max();
            int min = list.Min();

            return min.ToString() + " " + max.ToString();
    }
}