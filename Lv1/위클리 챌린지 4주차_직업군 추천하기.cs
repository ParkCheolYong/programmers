using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] table, string[] languages, int[] preference) {
        Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < 5; i++)
            {
                string[] arrLanguages = table[i].Split(' ');
                string job = string.Empty;
                int score = 0;

                for (int j = 0; j <=5; j++)
                {
                    if (j == 0)
                    {
                        job = arrLanguages[j];
                    }
                    else
                    {
                        for (int k = 0; k < languages.Length; k++)
                        {
                            if (languages[k] == arrLanguages[j])
                            {
                                score += (6 - j) * preference[k];
                                break;
                            }
                        }
                    }
                }

                dic.Add(job, score);
            }

            return dic.OrderBy(x => x.Key).First(x => x.Value == dic.Max(z => z.Value)).Key;
    }
}