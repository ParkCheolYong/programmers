using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] genres, int[] plays)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < genres.Length; i++)
            {
                if (!dic.ContainsKey(genres[i]))
                {
                    dic.Add(genres[i], plays[i]);
                }
                else
                {
                    dic[genres[i]] += plays[i];
                }
            }

            var genresList = dic.OrderByDescending(x => x.Value).ToList();

            List<int> answer = new List<int>();
            for (int i = 0; i < genresList.Count; i++)
            {
                List<Tuple<int,int>> list = new List<Tuple<int, int>>();

                for (int j = 0; j < plays.Length; j++)
                {
                    if (genresList[i].Key == genres[j])
                    {
                        list.Add(new Tuple<int, int>(j, plays[j]));
                    }
                }

                list = list.OrderByDescending(x => x.Item2).ToList();

                answer.Add(list[0].Item1);
                if (list.Count > 1)
                    answer.Add(list[1].Item1);
            }

            return answer.ToArray();
        }
}