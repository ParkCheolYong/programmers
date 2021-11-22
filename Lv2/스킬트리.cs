using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string skill, string[] skill_trees) 
    {
        int answer = 0;

        Dictionary<int, char> dic = new Dictionary<int, char>();
        List<int> list = new List<int>();

        for (int i = 0; i < skill.Length; i++)
        {
            dic.Add(i, skill[i]);
        }

        foreach (string s in skill_trees)
        {
            list.Clear();

            foreach (char c in s)
            {
                if (dic.ContainsValue(c))
                {
                    list.Add(dic.FirstOrDefault(x => x.Value == c).Key);
                }
            }

            if (list.Where((x,idx) => x == idx).Count() == list.Count())
            {
                answer++;
            }
        }

        return answer;
    }
}