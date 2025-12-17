using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        string str = n.ToString();

        int num = 0;

        foreach (char c in str)
        {
            num = (int)(c-'0');
            answer += num;
        }

        return answer;
    }
}