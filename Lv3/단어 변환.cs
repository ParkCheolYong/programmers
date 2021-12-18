using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string begin, string target, string[] words)
        {
            if (!words.Contains(target)) return 0;

            Queue<Tuple<string, int>> q = new Queue<Tuple<string, int>>();
            List<string> usedWord = new List<string>();

            q.Enqueue(new Tuple<string, int>(begin, 0));

            while (q.Count > 0)
            {
                Tuple<string, int> word = q.Dequeue();

                usedWord.Add(word.Item1);

                //현재 단어가 target단어와 같을경우
                if (word.Item1 == target)
                {
                    return word.Item2;
                }

                for (int i = 0; i < words.Length; i++)
                {
                    //현재단어와 같으면 스킵
                    if (words[i] == word.Item1) continue;

                    //변환할때 사용했던 단어는 스킵
                    if (usedWord.Contains(words[i])) continue;

                    int diffCnt = 0;

                    //글자비교
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (word.Item1[j] != words[i][j]) diffCnt++;

                        //두글자 이상 다르면 더이상 비교하지 않음
                        if (diffCnt > 1) break;
                    }

                    if (diffCnt == 1)
                    {
                        //변환 가능 단어는 큐에 담음
                        q.Enqueue(new Tuple<string, int>(words[i], word.Item2 + 1));
                    }
                }
            }

            return 0;
        }
}