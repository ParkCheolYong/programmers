using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public bool solution(string s) {
            Stack<char> stack = new Stack<char>();

        if (s[0] == ')')
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push('(');
                }
                else
                {
                    if (stack.Count == 0)  return false;
                    else stack.Pop();
                }

                if (stack.Count > s.Length - i)
                {
                    return false;
                }
            }

            return stack.Count == 0;
    }
}