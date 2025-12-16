using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        double aa = Math.Sqrt(n);
        if (!(aa % 1 == 0))
            return 2;

        return 1;
    }
}