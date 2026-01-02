using System;

public class Solution
{
    bool IsOdd(int a)
    {
        if (a % 2 == 1)
            return true;
        else
            return false;
    }

    public int solution(int a, int b)
    {
        if(IsOdd(a) && IsOdd(b))
        {
            return a * a + b * b;
        }

        if (IsOdd(a) || IsOdd(b))
        {
            return (a + b) * 2;
        }

        return Math.Abs(a - b);
    }
}