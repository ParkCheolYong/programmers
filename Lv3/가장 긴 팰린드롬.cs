public class Solution {
    public int solution(string s)
        {
            int answer = 0;

            if (s.Length == 1) return 1;

            for (int i = 1; i < s.Length; i++)
            {
                int EvenNumber = PalindromeLength(s, i, i + 1);
                int OddNumber = PalindromeLength(s, i, i);

                if (EvenNumber > answer)
                {
                    answer = EvenNumber;
                }

                if (OddNumber > answer)
                {
                    answer = OddNumber;
                }
            }

            return answer;
        }

    public int PalindromeLength(string s, int pLeftIdx, int pRightIdx)
        {
            int LeftIdx = pLeftIdx;
            int RightIdx = pRightIdx;
            int answer = 0;

            while (LeftIdx >= 0 && RightIdx < s.Length && s[LeftIdx] == s[RightIdx])
            {
                LeftIdx--;
                RightIdx++;
            }

            if (RightIdx - LeftIdx - 1 > answer)
            {
                answer = RightIdx - LeftIdx - 1;
            }

            return answer;
        }
}