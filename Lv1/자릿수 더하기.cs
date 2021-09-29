using System;
using System.Linq;

public class Solution 
{
    public int solution(int n) 
    { 
        return n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum();
    }
}