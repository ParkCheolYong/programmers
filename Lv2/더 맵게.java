import java.util.PriorityQueue;

class Solution {
    public int solution(int[] scoville, int K) {
        int answer = 0;

        PriorityQueue<Integer> heap = new PriorityQueue<Integer>();

        for(int i = 0; i < scoville.length; i++)
        {
            heap.offer(scoville[i]);
        }

        while(heap.peek() < K)
        {
            if (heap.size() < 2) return -1;

            int n1 = heap.poll();
            int n2 = heap.poll();

            int newScoville = n1 + (n2 * 2);

            heap.offer(newScoville);
            answer++;
        }              

        return answer;
    }
}