using System;

public class Solution
{
    public int solution(string number)
    {
        int answer = 0;

        string temp = number.ToString();

        for(int i=0;i<temp.Length;i++)
        {
            answer += temp[i] - '0';
        }


        return answer % 9;
    }
}