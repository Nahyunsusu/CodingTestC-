using System;

public class Solution
{
    public int solution(int a, int b)
    {
        string strA = a.ToString();
        string strB = b.ToString();

        string ab = strA + strB;
        string ba = strB + strA;

        return Math.Max(int.Parse(ab), int.Parse(ba));
    }
}