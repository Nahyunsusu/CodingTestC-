using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        int temp;

        while(n > 0)
        {
            temp = n % 10;
            answer += temp;
            n = n / 10;
        }

        return answer;
    }
}