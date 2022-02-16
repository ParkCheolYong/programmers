import java.util.*;

class Solution {
    public int[] solution(String msg) {
        Map<String, Integer> dic = new HashMap<String, Integer>();
        List<Integer> list = new ArrayList<>();
        
        boolean isEnd = false;
        
        for (int i = 65; i <= 90; i++)
        {
        	dic.put(Character.toString((char)i), i - 64);
        }
       
        for (int i = 0; i < msg.length(); i++)
        {
        	String word = msg.charAt(i) + "";
        	
        	while (dic.containsKey(word))
        	{        	
        		i++;
        		
        		if (i == msg.length())
        		{
        			isEnd = true;
        			break;
        		}
        		
        		word += msg.charAt(i) + "";
        	}
        	
        	if (isEnd)
        	{
        		list.add(dic.get(word));
        		break;
        	}
        	
        	
        	list.add(dic.get(word.substring(0, word.length() - 1)));
        	dic.put(word, dic.size() + 1);   
        	
        	i--;
        }
        
        int[] answer = new int[list.size()];
        
        for (int i = 0; i < list.size(); i++)
        {
        	answer[i] = list.get(i);        	
        }
        
        return answer;
    }
}