using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n, int k, int[] enemy)
    {
        int answer = 0;

        if (k >= enemy.Length) return enemy.Length;

        MaxHeap maxHeap = new MaxHeap();

        for (int i = 0; i < enemy.Length; i++)
        {
            //남은 병사로 적을 막음
            if (n >= enemy[i])
            {
                n -= enemy[i];

                //MaxHeap에 막은 적의 수를 담음
                maxHeap.Add(enemy[i]);

                answer++;
            }
            //남은 병사로 적을 막을 수 없을 때
            else
            {
                //무적권 유무 확인
                if (k > 0)
                {
                    //현재 막아야할 적 보다 MaxHeap에 값이 크면 지나온 라운드에서 무적권을 사용
                    if (maxHeap.Count() > 0 && enemy[i] < maxHeap.GetMaxValue())
                    {
                        n += maxHeap.GetMaxValue();
                        maxHeap.RemoveMaxValue();
                        i--;
                        answer--;
                    }

                    //무적권 사용
                    k--;
                    answer++;
                }
                //무적권 다 쓰면 게임 종료
                else
                {
                    break;
                }
            }
        }

        return answer;
    }
}

public class MaxHeap
{
    List<int> heap = new List<int>();

    public void Add(int value)
    {
        heap.Add(value);

        int idx = heap.Count - 1;
        while(idx > 0)
        {
            int parent = (idx - 1) / 2;
            if (heap[parent] < heap[idx])
            {
                Swap(parent, idx);
                idx = parent;
            }
            else
            {
                break;
            }
        }
    }

    public void RemoveMaxValue()
    {
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        int i = 0;
        int last = heap.Count - 1;
        while (i < last)
        {
            int child = i * 2 + 1;

            if (child < last && heap[child] < heap[child + 1])
            {
                child++;
            }

            if (child > last || heap[i] >= heap[child]) break;

            Swap(i, child);
            i = child;
        }
    }

    public int Count()
    {
        return heap.Count;
    }

    public int GetMaxValue()
    {
        return heap[0];
    }

    public void Swap(int i, int j)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}