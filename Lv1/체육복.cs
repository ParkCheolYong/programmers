using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
            List<int> lstLost = new List<int>(lost);
            List<int> lstReserve = new List<int>(reserve);

            lstReserve = lstReserve.Where(p => !lost.Contains(p)).ToList();
            lstLost = lstLost.Where(p => !reserve.Contains(p)).ToList();

            answer = n - lstLost.Count;

            for (int idx = 0; idx < lstLost.Count; idx++)
            {
                if (lstReserve.Contains(lstLost[idx] - 1))
                {
                    lstReserve.Remove(lstLost[idx] - 1);
                    answer++;
                }
                else if (lstReserve.Contains(lstLost[idx] + 1))
                {
                    lstReserve.Remove(lstLost[idx] + 1);
                    answer++;
                }
            }

            return answer;
    }
}