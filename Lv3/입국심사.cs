using System;
using System.Linq;

public class Solution {
    public Int64 solution(Int64 n, int[] times)
        {
            Array.Sort(times);

            Int64 low = 0;
            Int64 high = times.Last() * n;

            while (low != high)
            {
                Int64 mid = (low + high) / 2;
                Int64 immigrationPeople = 0;

                for (int i = 0; i < times.Length; i++)
                {
                    immigrationPeople += mid / times[i];
                }

                if (immigrationPeople >= n)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }
}