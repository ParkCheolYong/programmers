using System;

public class Solution 
{
    public long[] solution(long[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i]++;
                    continue;
                }

                long bit = 1;
                while (true)
                {
                    if((numbers[i] & bit) == 0)
                    {
                        break;
                    }
                    bit *= 2;
                }
                bit /= 2;

                numbers[i] += bit;
        }
            return numbers;
    }
}