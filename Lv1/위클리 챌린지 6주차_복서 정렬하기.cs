using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] weights, string[] head2head)
        {
            //double : 승률
            //int[0] : 무거운 복서 이긴 횟수
            //int[1] : 본인 몸무게
            //int[2] : 번호
            List<Tuple<double, int[]>> playerInfoList = new List<Tuple<double, int[]>>();

            //선수 수
            int playerCnt = weights.Length;

            for (int i = 0; i < playerCnt; i++)
            {
                //이긴 횟수
                int winCnt = 0;
                //자신보다 무거운 복서 이긴횟수
                int overWeightCnt = 0;
                //경기횟수
                int playCnt = 0;

                for (int j = 0; j < playerCnt; j++)
                {
                    //자기 자신과는 싸울 수 없음
                    if (i == j) continue;
                    //승률 계산을 위해 경기횟수를 구함
                    if (head2head[i][j] != 'N') playCnt++;

                    if (head2head[i][j] == 'W')
                    {
                        winCnt++;

                        if (weights[i] < weights[j])
                        {
                            overWeightCnt++;
                        }
                    }
                }

                //승률계산
                double winRate = playCnt == 0 ? 0 :(double)winCnt / playCnt;

                playerInfoList.Add(new Tuple<double, int[]>(winRate, new int[] { overWeightCnt, weights[i], i + 1 }));
            }

            //전체 승률이 높은 복서의 번호가 앞쪽으로 갑니다.
            //승률이 동일한 복서의 번호들 중에서는 자신보다 몸무게가 무거운 복서를 이긴 횟수가 많은 복서의 번호가 앞쪽으로 갑니다.
            //자신보다 무거운 복서를 이긴 횟수까지 동일한 복서의 번호들 중에서는 자기 몸무게가 무거운 복서의 번호가 앞쪽으로 갑니다.
            //자기 몸무게까지 동일한 복서의 번호들 중에서는 작은 번호가 앞쪽으로 갑니다.
            playerInfoList = playerInfoList.OrderByDescending(x => x.Item1).ThenByDescending(x => x.Item2[0]).ThenByDescending(x => x.Item2[1]).ThenBy(x => x.Item2[2]).ToList();

            return playerInfoList.Select(x => x.Item2[2]).ToArray();
        }
}