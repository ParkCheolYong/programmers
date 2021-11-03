using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(int bridge_length, int weight, int[] truck_weights) 
    {
        int answer = 1;

            Queue<int> waitQ = new Queue<int>();
            Queue<Tuple<int, int>> bridgeQ = new Queue<Tuple<int, int>>();

            foreach (int i in truck_weights)
            {
                waitQ.Enqueue(i);
            }

            do
            {
                answer++;

                int weightSum = bridgeQ.Select(x => x.Item1).Sum();
                int truckCnt = bridgeQ.Count();

                if (waitQ.Count > 0 && truckCnt < bridge_length && weightSum + waitQ.Peek() <= weight)
                    bridgeQ.Enqueue(new Tuple<int, int>(waitQ.Dequeue(), 0));

                var tempQ = bridgeQ.Select(x => new Tuple<int, int>(x.Item1, x.Item2 + 1)).ToList();
                bridgeQ.Clear();

                foreach (Tuple<int, int> tuple in tempQ)
                {
                    bridgeQ.Enqueue(tuple);
                }

                if (bridgeQ.Peek().Item2 == bridge_length)
                {
                    bridgeQ.Dequeue();
                }
            }
            while (waitQ.Count > 0 || bridgeQ.Count > 0);

            return answer;
    }
}