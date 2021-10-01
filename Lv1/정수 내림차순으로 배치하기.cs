using System;
using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
         string a = n.ToString();
            List<int> nList = new List<int>();
            

            foreach (var val in a)
            {
                nList.Add(int.Parse(val.ToString()));
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nList[j] < nList[i])
                    {
                        int temp = nList[i];
                        nList[i] = nList[j];
                        nList[j] = temp;

                    }
                }
            }

            a = string.Empty;

            foreach (var val in nList)
            {
                a = string.Format("{0}{1}", a, val);
            }

            return long.Parse(a);
    }
}