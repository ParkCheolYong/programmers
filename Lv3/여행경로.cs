using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<string[]> routeList = new List<string[]>();

    public string[] solution(string[,] tickets)
        {
            int routeCnt = tickets.GetLength(0);


            for (int i = 0; i < tickets.GetLength(0); i++)
            {
                List<string> arrRoute = new List<string>();
                bool[] visited = new bool[routeCnt];

                if (tickets[i, 0] == "ICN")
                {
                    arrRoute.Add(tickets[i, 0]);
                    arrRoute.Add(tickets[i, 1]);
                    visited[i] = true;
                    dfs(i, tickets, visited, arrRoute);                    
                }
            }

            string[] temp = routeList.First();

            foreach(string[] arrRoute in routeList)
            {
                for (int i = 0; i < routeCnt + 1; i++)
                {
                    if (temp[i] != arrRoute[i])
                    {
                        if (string.Compare(temp[i], arrRoute[i]) == 1) temp = arrRoute;

                        break;
                    }
                }
            }

            return temp;
        }



        public void dfs(int i, string[,] tickets, bool[] visited, List<string> arrRoute)
        {
            if (visited.Contains(false))
            {
                for (int j = 0; j < tickets.GetLength(0); j++)
                {
                    if (i == j) continue;

                    if (!visited[j] && tickets[i, 1] == tickets[j, 0])
                    {
                        visited[j] = true;
                        arrRoute.Add(tickets[j, 1]);                                   
                        dfs(j, tickets, visited, arrRoute);
                        visited[j] = false;
                        arrRoute.RemoveAt(arrRoute.Count - 1);
                    }
                }
            }
            else
            {
                if (arrRoute.Count != tickets.GetLength(0) + 1)
                {
                    return;
                }

                routeList.Add(arrRoute.ToArray());                
            }
        }
}