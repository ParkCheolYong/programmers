using System;
using System.Collections.Generic;
using System.Linq;

class Solution 
{
        public int solution(int n)
        {

            int i = GetBinaryOneCnt(n);

            while (true)
            {
                if (i == GetBinaryOneCnt(++n))
                {
                    break;
                }
            }

            return n;
        }

        public int GetBinaryOneCnt(int n)
        {
            int result = 0;

            while (n != 0)
            {
                if (n % 2 == 1) result++;

                n /= 2;
            }

            return result;
        }
}