using System;

public class Solution
{
    public string solution(int age)
    {
        string temp = age.ToString();

        string answer = "";

        for(int i=0;i<temp.Length;i++)
        {
            answer += (char)(temp[i] - '0' + 'a');
        }

        return answer;
    }
}