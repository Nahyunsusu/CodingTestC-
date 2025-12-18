using System;

public class Solution
{
    public int solution(int a, int b)
    {
        int answer = 0;

        string temp = a.ToString() + b.ToString();

        answer = int.Parse(temp);

        return answer > 2*a*b ? answer: 2*a*b;
    }
}