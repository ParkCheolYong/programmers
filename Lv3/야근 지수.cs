using System;
using System.Linq;

public class Solution {
    public long solution(int n, int[] works)
        {
            while (n > 0)
            {        
                Array.Sort(works);
                Array.Reverse(works);

                for (int i = 0; i < works.Length - 1; i++)
                {
                    if (n == 0) break;

                    if (works[i] > 0)
                    {
                        n--;
                        works[i]--;

                        if (works[i] >= works[i + 1] && n > 0)
                        {
                            i = -1;
                            continue;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            return (long)works.Select(x => Math.Pow(x, 2)).Sum(); 
        }
}