using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s)
    {
        int answer = 0;

        Queue<char> queue = new Queue<char>(s.ToCharArray());
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            stack.Clear();
            answer += Check(queue, stack);
            queue.Enqueue(queue.Dequeue());
        }

        return answer;
    }

    public int Check(Queue<char> queue, Stack<char> stack)
    {
        foreach (char c in queue)
        {
            if (c == '[' || c == '(' || c == '{')
                stack.Push(c);
            else if (stack.Count == 0)
                return 0;
            else if (stack.Peek() == '[' && c != ']')
                return 0;
            else if (stack.Peek() == '(' && c != ')')
                return 0;
            else if (stack.Peek() == '{' && c != '}')
                return 0;
            else
                stack.Pop();
        }

        return stack.Count == 0 ? 1 : 0;
    }
}
