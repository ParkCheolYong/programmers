using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] jobs)
        {
            double sum = 0;

            List<Job> jobList = new List<Job>();

            for (int i = 0; i < jobs.GetLength(0); i++)
            {
                jobList.Add(new Job( jobs[i, 0], jobs[i, 1] ));
            }

            //요청시간순으로 정렬 , 요청시간이 같으면 소요시간순으로 정렬
            jobList.Sort((x, y) => x.requestTime == y.requestTime ? (x.taskTime > y.taskTime ? 1 : -1) : (x.requestTime > y.requestTime ? 1 : -1));

            //요청 시작 시점
            int reqStartTime = 0;

            //대기 시간
            int waitingTime = 0;

            //작업 시간
            int taskTime = 0;

            //작업 종료 시점
            int taskEndTime = jobList[0].requestTime + jobList[0].taskTime;

            //정렬된 요청 리스트의 첫번째 값을 담고 리스트에서 제거함
            sum = jobList[0].taskTime;
            jobList.RemoveAt(0);

            Queue<Job> q = new Queue<Job>(jobList);

            List<Job> waitingList = new List<Job>();

            do
            {
                if (q.Count > 0)
                {
                    if (q.Peek().requestTime < taskEndTime)
                    {
                        //기존 작업의 종료시점보다 요청시점이 작은 작업들을 대기리스트에 담음
                        for (int i = 0; i < q.Count; i++)
                        {
                            if (q.Peek().requestTime < taskEndTime)
                            {
                                waitingList.Add(q.Dequeue());
                                i--;
                            }
                            else
                            {
                                break;
                            }
                        }

                        //대기리스트의 소요시간 기준으로 정렬
                        waitingList.Sort((x, y) => x.taskTime > y.taskTime ? 1 : -1);
                    }
                    else
                    {
                        waitingList.Add(q.Dequeue());
                    }
                }

                if (waitingList.Count > 0)
                {
                    if (waitingList[0].requestTime < taskEndTime)
                    {
                        reqStartTime = waitingList[0].requestTime;
                        waitingTime = taskEndTime - reqStartTime;
                        taskTime = waitingTime + waitingList[0].taskTime;
                        taskEndTime += waitingList[0].taskTime;
                    }
                    else
                    {
                        taskTime = waitingList[0].taskTime;
                        taskEndTime = waitingList[0].requestTime + waitingList[0].taskTime;
                    }


                    sum += taskTime;
                    waitingList.RemoveAt(0);                  
                }

            } while (waitingList.Count > 0 || q.Count > 0);

            return (int)(sum / jobs.GetLength(0));
        }
}

public class Job
    {
        public int requestTime { get; set; }
        public int taskTime { get; set; }

        public Job(int pRequestTime, int pTaskTime)
        {
            this.requestTime = pRequestTime;
            this.taskTime = pTaskTime;
        }
    }