import java.util.*;

class Solution {
    public String[] solution(String[] record) {        
        
        Map<String,String> map = new HashMap<String, String>();
        Queue<String> q = new LinkedList<String>();
        
        for (int i = 0; i < record.length; i++)
        {
        	String[] arrInfo = record[i].split("\\s"); 
        	
        	if (arrInfo[0].equals("Enter"))
        	{
        		map.put(arrInfo[1], arrInfo[2]);
        		q.offer(arrInfo[1] + "님이 들어왔습니다.");
        	}
        	else if (arrInfo[0].equals("Leave"))
        	{
        		q.offer(arrInfo[1] + "님이 나갔습니다.");
        	}
        	else
        	{
        		map.put(arrInfo[1], arrInfo[2]);
        	}
        }
        
        String[] answer = new String[q.size()];
        int i = 0;
        while (q.size() > 0)
        {
        	String user = q.poll();
        	int idx = user.indexOf("님");
        	String id = user.substring(0,idx);        	
        	
        	answer[i] = user.replace(id, map.get(id));
        	i++;
        }

        return answer;
    }
}