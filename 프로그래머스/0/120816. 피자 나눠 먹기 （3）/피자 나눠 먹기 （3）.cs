using System;

public class Solution
{
    public int solution(int slice, int n)
    {
        int need = n % slice;

        if (need > 0)
            return (n / slice) + 1;

        return n / slice;
    }
}