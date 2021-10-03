using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int s = arr.Min();
            int[] answer = arr.Where(x => x != s).ToArray();

            if (answer.Count() == 0)
            {
                answer = new int[] { -1 };
            }

            return answer;
    }
}