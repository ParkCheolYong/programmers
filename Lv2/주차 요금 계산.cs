using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] fees, string[] records)
    {        
        List<string[]> recordList = new List<string[]>();
        int minutes = 0;

        foreach(string s in records)
        {
            recordList.Add(s.Split(' '));
        }

        //입차 리스트
        List<string[]> inList = recordList.Where(x => x[2] == "IN").ToList();
        //출차 리스트
        List<string[]> outList = recordList.Where(x => x[2] == "OUT").ToList();
        //<차번호, 누적시간(분)>
        Dictionary<string, int> cumulativeTime = new Dictionary<string, int>();

        for (int i = 0; i < inList.Count(); i++)
        {
            for (int j = 0; j < outList.Count(); j++)
            {
                if (inList[i][1] == outList[j][1])
                {
                    //주차 시간 계산
                    minutes = CalcMinutes(inList[i][0], outList[j][0]);

                    //주차 시간 누적
                    if (cumulativeTime.ContainsKey(inList[i][1]))
                    {
                        cumulativeTime[inList[i][1]] += minutes;
                    }
                    else
                    {
                        cumulativeTime.Add(inList[i][1], minutes);
                    }

                    //입차 내역 제거
                    inList.RemoveAt(i);
                    i--;

                    //출차 내역 제거
                    outList.RemoveAt(j);
                    break;
                }
            }
        }

        //출차내역 없는 차량 시간 계산
        for (int i = 0; i < inList.Count(); i++)
        {
            //주차 시간 계산
            minutes = CalcMinutes(inList[i][0], "23:59");

            //주차 시간 누적
            if (cumulativeTime.ContainsKey(inList[i][1]))
            {
                cumulativeTime[inList[i][1]] += minutes;
            }
            else
            {
                cumulativeTime.Add(inList[i][1], minutes);
            }
        }

        return cumulativeTime.OrderBy(x => x.Key).Select(x => CalcFee(fees, x.Value)).ToArray();
    }
    
    //시간 계산
    public int CalcMinutes(string inTime, string outTime)
    {
        TimeSpan datediff = Convert.ToDateTime(outTime) - Convert.ToDateTime(inTime);

        return (int)datediff.TotalMinutes;
    }
    
    //비용 계산
    public int CalcFee(int[] fees, int minutes)
    {
        if (minutes <= fees[0]) return fees[1];

        double a = Convert.ToDouble(minutes - fees[0]) / fees[2];
        int b = (int)Math.Ceiling(a);
        
        return fees[1] + b * fees[3];
    }
}