using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] enroll, string[] referral, string[] seller, int[] amount)
    {
        int[] answer = new int[enroll.Length];

        Dictionary<string, string> enrollReferral = new Dictionary<string, string>();
        Dictionary<string, int> enrollIdx = new Dictionary<string, int>();

        for (int i = 0; i < enroll.Length; i++)
        {
            enrollReferral.Add(enroll[i], referral[i]);
            enrollIdx.Add(enroll[i], i);
        }

        for (int i = 0; i < seller.Length; i++)
        {
            int revenue = amount[i] * 100;
            string sellerNode = seller[i];

            while (sellerNode != "-")
            {
                int fee = revenue / 10;
                int profit = revenue - fee;

                answer[enrollIdx[sellerNode]] += profit;

                sellerNode = enrollReferral[sellerNode];

                if (fee == 0) break;
                else revenue = fee;
            }
        }

        return answer;
    }
}