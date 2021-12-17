using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] operations)
        {
            int[] answer = new int[2];

            List<int> list = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                string[] command = operations[i].Split(' ');

                if (command[0] == "I")
                {
                    list.Add(int.Parse(command[1]));
                    list.Sort();
                }
                else
                {
                    if (list.Count != 0)
                    {
                        if (command[1] == "1")
                        {
                            list.RemoveAt(list.Count() - 1);
                        }
                        else
                        {
                            list.RemoveAt(0);
                        }
                    }

                }
            }

            if (list.Count != 0)
            {
                answer[0] = list[list.Count() - 1];
                answer[1] = list[0];
            }

            return answer;
        }
}