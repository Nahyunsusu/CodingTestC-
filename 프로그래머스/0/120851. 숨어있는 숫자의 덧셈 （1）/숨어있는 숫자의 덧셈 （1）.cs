using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;

        foreach(char ch in my_string)
        {
            if(ch > '0' && ch <= '9')
            {
                answer += ch - '0';
            }
        }

        return answer;
    }
}