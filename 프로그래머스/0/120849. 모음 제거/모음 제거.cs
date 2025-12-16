using System;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = my_string.Replace("u", "");
        answer = answer.Replace("a", "");
        answer = answer.Replace("o", "");
        answer = answer.Replace("i", "");
        answer = answer.Replace("e", "");

        return answer;
    }
}