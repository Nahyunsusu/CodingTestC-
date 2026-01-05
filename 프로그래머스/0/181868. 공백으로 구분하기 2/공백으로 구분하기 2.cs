using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        string[] words = my_string.Split(' ');

        List<string> result = new List<string>();

        foreach (string s in words)
        {
            if (s != "")
            {
                result.Add(s);
            }
        }

        return result.ToArray();
    }
}