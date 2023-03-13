using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[numbers.Length];

        Stack<int> stack = new Stack<int>();

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            while (stack.Count() != 0 && stack.Peek() <= numbers[i])
            {
                stack.Pop();
            }

            answer[i] = stack.Count() == 0 ? -1 : stack.Peek();
            stack.Push(numbers[i]);
        }

        return answer;
    }
}