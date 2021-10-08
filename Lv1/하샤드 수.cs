using System.Linq;

public class Solution 
{
    public bool solution(int x) 
    {
        return x % x.ToString().ToCharArray().Select(n => int.Parse(n.ToString())).Sum() == 0 ? true : false;
    }
}