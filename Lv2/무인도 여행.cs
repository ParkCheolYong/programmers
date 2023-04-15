using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public bool[,] visited;
    public int[,] direction = new int[,] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };

    public int[] solution(string[] maps)
    {
        int a = maps.Length;
        int b = maps[0].Length;
        visited = new bool[a, b];

        List<int> list = new List<int>();

        for (int i = 0; i < maps.Length; i++)
        {
            for (int j = 0; j < maps[i].Length; j++)
            {
                if (!visited[i, j] && maps[i][j] != 'X')
                {
                    Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
                    q.Enqueue(new Tuple<int, int>(i, j));
                    visited[i, j] = true;
                    int sum = int.Parse(maps[i][j].ToString());

                    while (q.Count() > 0)
                    {
                        int y = q.Peek().Item1;
                        int x = q.Dequeue().Item2;

                        for (int k = 0; k < 4; k++)
                        {
                            int nextY = y + direction[k, 0];
                            int nextX = x + direction[k, 1];

                            if (nextX >= 0 && nextX < b && nextY >= 0 && nextY < a
                                && !visited[nextY, nextX]
                                && maps[nextY][nextX] != 'X')
                            {
                                visited[nextY, nextX] = true;
                                q.Enqueue(new Tuple<int, int>(nextY, nextX));
                                sum += int.Parse(maps[nextY][nextX].ToString());
                            }
                        }
                    }

                    if (sum > 0)
                    {
                        list.Add(sum);
                    }
                }
            }
        }

        if (list.Count() > 0)
            return list.OrderBy(x => x).ToArray();
        else
            return new int[] { -1 };
    }
}