using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];

            int x = 0;

            for(int y = 1; y <= yellow; y++)
            {
                if (yellow % y == 0)
                {
                    x = yellow / y;

                    if ((x + y + 2) * 2 == brown)
                    {
                        answer[0] = x + 2;
                        answer[1] = y + 2;

                        return answer;
                    }
                }
            }

            return answer;
    }
}