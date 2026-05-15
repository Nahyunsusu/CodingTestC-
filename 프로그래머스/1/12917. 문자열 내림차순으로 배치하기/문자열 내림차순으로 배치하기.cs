using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        List<char> temp = s.ToList();

        temp.Sort();
        temp.Reverse();

        string answer = new string(temp.ToArray());

        return answer;
    }
}