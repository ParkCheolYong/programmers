using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int cnt = 0;
    public List<int> AllNumber = new List<int>();

    public int solution(string numbers) 
    {
        List<string> arr = numbers.Select(x => x.ToString()).ToList();

        List<string> list = new List<string>();

        for (int i = 0; i < arr.Count; i++)
        {
            GetNumber(arr, list, arr.Count, i + 1);
        }

        return cnt;
    }

    public void GetNumber(List<string> arr, List<string> list, int n, int r)
    {
        if (r == 0)
        {
            string strNumber = string.Empty;
            foreach (string s in list)
            {
                strNumber += s;
            }

            if (!string.IsNullOrEmpty(strNumber))
            {
                int number = int.Parse(strNumber);

                if (!AllNumber.Contains(number))
                {
                    AllNumber.Add(number);
                    IsPrimeNumber(number);
                }
            }
            return;
        }

        for (int i = 0; i < n; i++)
        {
            list.Add(arr[i]);
            arr.RemoveAt(i);

            GetNumber(arr, list, n - 1, r - 1);

            arr.Insert(i, list[list.Count - 1]);
            list.RemoveAt(list.Count - 1);
        }
    }

    private void IsPrimeNumber(int number)
    {
        if (number == 0 || number == 1) return;

        bool PrimeYn = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                PrimeYn = false;
                break;
            }
        }

        if (PrimeYn) cnt++;
    }
}