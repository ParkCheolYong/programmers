using System;
using System.Linq;


public class Solution {
    public int solution(string name) {
        int answer = 0;

            int[] arrName = name.Select(x => (int)x).ToArray();
            int idx = arrName.Length % 2 == 0 ? arrName.Length / 2 : arrName.Length / 2 + 1;
            bool IsContainA = false;

            for (int i = 0; i < idx ; i++)
            {
                if (name[i] == 'A')
                {
                    IsContainA = true;
                    break;
                }
            }

            if (IsContainA)
            {
                for (int i = 0; i < arrName.Length; i++)
                {
                    answer += GetCnt(arrName[i]);

                    if (arrName[i+1] == 'A')
                    {
                        answer += (i + 1);

                        for(int j = arrName.Length - 1; j > i + 1; j--)
                        {
                            answer += GetCnt(arrName[j]);

                            int cntA = 0;
                            for (int k = j - 1; k > i +1; k--)
                            {
                                if (arrName[k] != 65) break;
                                else cntA++;
                            }

                            if (cntA == j - (i + 2)) return answer;

                            answer++;
                        }

                        return answer - 1;
                    }
                    else
                    {
                        answer++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrName.Length; i++)
                {
                    answer += GetCnt(arrName[i]);

                    answer++;
                }

                return answer - 1;
            }

            return answer;
    }
    public int GetCnt(int n)
        {
            int returnCnt = 0;

            if (n <= 77)
            {
                returnCnt = n - 65;
            }
            else
            {
                returnCnt = 91 - n;
            }

            return returnCnt;
        }
}