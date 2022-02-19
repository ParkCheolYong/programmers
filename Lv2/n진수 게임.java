class Solution {
    public String solution(int n, int t, int m, int p) {
        String answer = "";
        String strNum = "";     
        
        int i = 0;
        
        while (strNum.length() < ((t - 1) * m) + p)
        {
        	strNum += ChangeNumber(n,i++);
        }
        
        strNum = strNum.substring(0, ((t - 1) * m) + p);
        
        for (int j = p - 1; j < strNum.length(); j += m)
        {
        	answer += Character.toString(strNum.charAt(j));
        }
                
        return answer;
    }
    
    public String ChangeNumber(int n, int m)
	{
		String strNum = "";		
		int num = 0;
		
		if (m == 0) return "0";
		
		while (m > 0)
		{
			num = m % n;
			
			if (num >= 10 && num <= 15)
			{				
				strNum += Character.toString((char)(num + 55));
			}
			else
			{
				strNum += num;
			}
						
			m /= n;
		}
		
		StringBuffer sb = new StringBuffer(strNum);
		
		return sb.reverse().toString();
	}
}