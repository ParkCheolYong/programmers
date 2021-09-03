using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        
        int intersectCnt = lottos.Intersect(win_nums).Count();
        int zeroCnt = lottos.Where(x => x == 0).Count();

        answer[0] = 7 - (zeroCnt + intersectCnt);
        answer[1] = 7 - intersectCnt;

        if (answer[0] == 7) answer[0] = 6;
        if (answer[1] == 7) answer[1] = 6;
        
        return answer;
    }
}