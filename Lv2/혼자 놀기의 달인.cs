using System;
using System.Linq;

public class Solution 
{
    public int solution(int[] cards) 
    {
        int answer = 0;

        int[] box1 = Enumerable.Repeat<int>(0, cards.Length).ToArray();
        int[] box2 = Enumerable.Repeat<int>(0, cards.Length).ToArray();
        int nextCard = 0;
        int group1 = 0;
        int group2 = 0;

        for (int i = 0; i < cards.Length; i++)
        {
            if (box1[i] == 0)
            {
                group1 = BoxOpen(box1, i, cards);

                if (cards.Length == group1)
                {
                    box1 = Enumerable.Repeat<int>(0, cards.Length).ToArray();
                    continue;
                }
            }

            for (int j = 0; j < cards.Length; j++)
            {
                box2 = (int[])box1.Clone();

                if (box2[j] == 0)
                {
                    group2 = BoxOpen(box2, j, cards);

                    answer = Math.Max(answer, (group1 * group2));
                }
            }

            box1 = Enumerable.Repeat<int>(0, cards.Length).ToArray();
        }

        return answer;
    }
    
    public int BoxOpen(int[] box, int idx, int[] cards)
    {
        box[idx] = 1;
        int nextCard = cards[idx] - 1;
        int cnt = 1;

        while (box[nextCard] == 0)
        {
            box[nextCard] = 1;
            nextCard = cards[nextCard] - 1;
            cnt++;
        }

        return cnt;
    }
}