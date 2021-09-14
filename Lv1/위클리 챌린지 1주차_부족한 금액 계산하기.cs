using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalMoney = 0;

            for (int i = 1; i <= count; i++)
            {
                totalMoney += (i * price);
            }

            return money >= totalMoney ? 0 : totalMoney - money;
    }
}