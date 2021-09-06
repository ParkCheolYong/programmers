using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
            bool primeNumberYn = true;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int f = j + 1; f < nums.Length; f++)
                    {
                        int sum = nums[i] + nums[j] + nums[f];
                        int sqrt = (int)Math.Sqrt(sum);
                        
                        for (int k = 2; k <= sqrt; k++)
                        {
                            primeNumberYn = true;

                            if (sum % k == 0)
                            {
                                primeNumberYn = false;
                                break;
                            }
                        }

                        if (primeNumberYn) answer++;
                    }
                }
            }

            return answer;
    }
}