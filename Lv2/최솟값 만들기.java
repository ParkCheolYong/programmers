import java.util.Arrays;
class Solution
{
    public int solution(int []A, int []B)
    {
        int answer = 0;

            for(int i = 0; i < B.length; i++)  { //B배열 내림차순 정렬
              for(int j = i; j < B.length; j++){                                       
                if(B[i] < B[j]){                         
                  int temp = B[i];
                  B[i] = B[j];
                  B[j] = temp;
                }
              }
            }
            Arrays.sort(A);
        for(int i=0; i<A.length; i++){
            answer+=A[i]*B[i];
        }

        return answer;
    }
}