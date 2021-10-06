public class Solution 
{
    public int solution(int num) 
    {
        if (num == 1) return 0;
        
        int answer = 0;
            long number = num;

            while (answer < 500)
            {
                if (number % 2 == 0)
                {
                    number /= 2;

                    if (number == 1)
                    {
                        answer++;
                        break;
                    }
                }
                else
                {
                    number = number * 3 + 1;
                }

                answer++;
            }

            return answer == 500 ? -1 : answer;
    }
}