using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string num_str)
    {
        List<char> answer = new List<char>();

        answer = num_str.ToList();

        int num = 0;

        foreach(char c in answer)
        {
            num += c - '0';
        }

        return num;
    }
}