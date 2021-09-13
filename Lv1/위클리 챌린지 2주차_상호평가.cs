using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[,] scores)
        {
            string answer = "";

            for (int j = 0; j < scores.GetLength(1); j++)
            {
                int selfScore = 0;
                List<int> list = new List<int>();

                for (int i = 0; i < scores.GetLength(0); i++)
                {
                    if (j == i)
                        selfScore = scores[i, j];
                    else
                        list.Add(scores[i, j]);
                }

                if (CheckSelfScore(selfScore, list.Max(), list.Min()))
                {
                    list.Add(selfScore);
                    answer += GetGrade(list.Average());
                }
                else
                {
                    answer += GetGrade(list.Average());
                }
            }

            return answer;
        }

        public bool CheckSelfScore(int pSelfSocre, int pMaxSocre, int pMinScore)
        {
            if (pSelfSocre > pMaxSocre)
                return false;
            else if (pSelfSocre < pMinScore)
                return false;

            return true;
        }

        public string GetGrade(double pAvgScore)
        {
            if (pAvgScore >= 90)
                return "A";
            else if (pAvgScore >= 80 && pAvgScore < 90)
                return "B";
            else if (pAvgScore >= 70 && pAvgScore < 80)
                return "C";
            else if (pAvgScore >= 50 && pAvgScore < 70)
                return "D";
            else
                return "F";
        }
}