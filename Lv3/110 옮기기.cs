using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string[] solution(string[] s)
    {
        string[] answer = new string[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            string s2 = s[i];
            string word = "";
            StringBuilder sb = new StringBuilder();

            //110을 모두 제거함
            Stack<char> stack = new Stack<char>();
            for (int j = 0; j < s2.Length; j++)
            {
                char temp1 = s2[j];

                if (stack.Count >= 2)
                {
                    char temp2 = stack.Pop();
                    char temp3 = stack.Pop();

                    if (temp3 == '1' && temp2 == '1' && temp1 == '0')
                    {
                        sb.Append("110");
                        continue;
                    }
                    else
                    {
                        stack.Push(temp3);
                        stack.Push(temp2);
                        stack.Push(temp1);
                    }
                }
                else
                {
                    stack.Push(temp1);
                }
            }

            word = sb.ToString();

            if (stack.Count > 0)
            {
                s2 = string.Join("", stack.ToArray().Reverse());
            }
            else
            {
                answer[i] = word;
                continue;
            }

            //110을 제거하고 0이 없을땐 110이 제일 앞으로 들어가야 작아짐
            if (!s2.Contains('0'))
            {
                s2 = word + s2;
            }
            //0이 있을땐 110이 마지막 0 뒤로 들어가야 작아짐
            else
            {
                for (int j = s2.Length - 1; j >= 0; j--)
                        {
                            if (s2[j] == '0')
                            {
                                s2 = s2.Insert(j + 1, word);
                                break;
                            }
                        }
            }

            answer[i] = s2;
        }

        return answer;
    }
}