using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string dirs) {
        int answer = 0;
            int[] position = { 0, 0, 0, 0 };

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < dirs.Length; i++)
            {
                switch (dirs[i])
                {
                    case 'U':
                        if (position[1] < 5) position[3] += 1;
                        else continue;
                        break;
                    case 'L':
                        if (position[0] > -5) position[2] -= 1;
                        else continue;
                        break;
                    case 'R':
                        if (position[0] < 5) position[2] += 1;
                        else continue;
                        break;
                    case 'D':
                        if (position[1] > -5) position[3] -= 1;
                        else continue;
                        break;
                }

                if (!list.Any(x => (x[0] == position[0] && x[1] == position[1] && x[2] == position[2] && x[3] == position[3])
                                || (x[0] == position[2] && x[1] == position[3] && x[2] == position[0] && x[3] == position[1])))
                {
                    list.Add(new int[] { position[0], position[1], position[2], position[3] });
                    answer++;
                }

                position[0] = position[2];
                position[1] = position[3];
            }

            return answer;
    }
}