using System;

public class Solution
{
    public long solution(long n)
    {
        double root = Math.Sqrt(n);

        long x = (long)root;

        if (x * x == n)
        {
            return (x + 1) * (x + 1);
        }

        return -1;
    }
}