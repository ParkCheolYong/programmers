using System;

class Solution
{
    public int solution(int N, int[,] road, int K)
    {
        int answer = 0;
            int[] distance = new int[N + 1];

            //미방문 노드 초기화
            for (int i = 2; i < distance.Length; i++)
            {
                distance[i] = 999999;
            }

            for (int k = 0; k < N; k++)
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 0; j < road.GetLength(0); j++)
                    {
                        if (road[j, 0] == i)
                        {
                            //최단경로 갱신
                            if (distance[road[j, 1]] > distance[road[j, 0]] + road[j, 2])
                            {
                                distance[road[j, 1]] = distance[road[j, 0]] + road[j, 2];
                            }

                        }
                        else if (road[j, 1] == i)
                        {
                            if (distance[road[j, 0]] > distance[road[j, 1]] + road[j, 2])
                            {
                                distance[road[j, 0]] = distance[road[j, 1]] + road[j, 2];
                            }
                        }
                    }
                }
            }


            for (int i = 1; i < distance.Length; i++)
            {
                if (distance[i] <= K)
                {
                    answer++;
                }
            }

            return answer;
    }
}