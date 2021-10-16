class Solution {
    public String solution(int n) {
        String answer = "";

        int b=0;//나머지

        while(n>0) {
            b=n%3;
            n=n/3;

            if(b==0) {
                n-=1;
                b=4;
            }
            answer=b+answer;
        }
        return answer;
    }
}