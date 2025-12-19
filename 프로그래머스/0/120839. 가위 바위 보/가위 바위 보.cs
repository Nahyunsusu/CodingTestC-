using System;

public class Solution
{
    public string solution(string rsp)
    {
        string answer = "";

        foreach(char ch in rsp)
        {
            if (ch == '2')
                answer += '0';
            if (ch == '0')
                answer += '5';
            if (ch == '5')
                answer += '2';
        }

        return answer;
    }
}