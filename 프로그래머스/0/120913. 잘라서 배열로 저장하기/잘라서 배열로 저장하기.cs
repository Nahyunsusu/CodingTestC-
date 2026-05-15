using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_str, int n)
    {
        List<string> answer = new List<string>();

        while(my_str.Length > 0)
        {
            int length = Math.Min(n, my_str.Length);

            string temp = my_str.Substring(0, length);
            answer.Add(temp);

            my_str = my_str.Substring(length);
        }

        return answer.ToArray();
    }
}