class Solution {
	  public int solution(int n) {
	      int answer = 0;
	      for(int i=1; i<=n; i++) {
	    	  int a=0;
	    	  for(int j=i; j<=n; j++) {
	    		  a+=j;
	    		  if(a==n) {
	    			  answer++;
	    			  break;
	    		  }else if(a>n) {
	    			  break;
	    		  }
	    	  }
	      }
	      return answer;
	  }
}