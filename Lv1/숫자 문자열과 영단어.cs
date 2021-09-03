using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        Dictionary<int, string> dicNum = new Dictionary<int, string>();
            dicNum.Add(0, "zero");
            dicNum.Add(1, "one");
            dicNum.Add(2, "two");
            dicNum.Add(3, "three");
            dicNum.Add(4, "four");
            dicNum.Add(5, "five");
            dicNum.Add(6, "six");
            dicNum.Add(7, "seven");
            dicNum.Add(8, "eight");
            dicNum.Add(9, "nine");

            if (int.TryParse(s, out answer))
            {
                return answer;
            }
            else
            {
                int num = 0;
                string strNum = "";
                string engWord = "";

                for (int i = 0; i < s.Length; i++)
                {
                    if (int.TryParse(s.ElementAt(i).ToString(), out num))
                    {
                        strNum += num.ToString();
                    }
                    else
                    {
                        engWord += s.ElementAt(i).ToString();

                        if (dicNum.ContainsValue(engWord))
                        {
                            strNum += dicNum.FirstOrDefault(x => x.Value == engWord).Key.ToString();
                            engWord = "";
                        }
                    }
                }

                answer = int.Parse(strNum);

                return answer;
            }        
    }
}