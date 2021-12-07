using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public int solution(int N, int number)
    {
        List<HashSet<int>> list = new List<HashSet<int>>();
        list.Add(new HashSet<int>());

        for (int i = 1; i <= 8; i++)
        {
            list.Add(new HashSet<int>());

            //N 여러개 붙여서 만든 숫자 만들기
            StringBuilder sb = new StringBuilder();
            int num = 0;
            num = int.Parse(sb.Insert(0, N.ToString(), i).ToString());
            if (number == num)
            {
                return i;
            }
            else
            {
                list[i].Add(num);
            }

            /*
            1번 사용 : 1

            2번 사용 : 1 + 1

            3번 사용 : 1 + 2
                       2 + 1

            4번 사용 : 1 + 3
                       2 + 2
                       3 + 1

            N을 n번 사용해서 만들 수 있는 수 :
            N을 n번 연달아서 사용할 수 있는 수 U
            N을 1번 사용했을 때 SET 과 n-1번 사용했을 때 SET을 사칙연산한 수들의 집합 U
            N을 2번 사용했을 때 SET 과 n-2번 사용했을 때 SET을 사칙연산한 수들의 집합 U
            ... U
            N을 n-1번 사용했을 때 SET 과 1번 사용했을 때 SET을 사칙연산한 수들의 집합
             */
            for (int j = 1; j < i; j++)
            {
                foreach (int val1 in list[j])
                {
                    foreach (int val2 in list[i - j])
                    {
                        int plus = val1 + val2;
                        if (plus == number) return i;
                        else list[i].Add(plus);

                        int minus = val1 - val2;
                        if (minus == number) return i;
                        else list[i].Add(minus);

                        int multiply = val1 * val2;
                        if (multiply == number) return i;
                        else list[i].Add(multiply);

                        if (val2 != 0)
                        {
                            int division = val1 / val2;
                            if (division == number) return i;
                            else list[i].Add(division);
                        }
                    }
                }
            }
        }

        return -1;
    }
}