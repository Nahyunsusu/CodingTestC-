using System;
using System.Collections.Generic;
public class Solution
{
    public string[] solution(string my_string)
    {
        List<string> answer = new List<string>();

        string temp = "";

        for(int i=0; i<my_string.Length;i++)
        {
            temp = my_string.Substring(i);
            answer.Add(temp);
            temp = string.Empty;
        }

        answer.Sort();

        return answer.ToArray();
    }
}