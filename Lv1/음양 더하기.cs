using System;
using System.Linq;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        return absolutes.Zip(signs.Select(x => x ? 1 : -1).ToArray(), (t1, t2) => t1 * t2).Sum();
    }
}