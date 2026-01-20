using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        List<string> temp = s.Split(' ').ToList();

        for (int i = 0; i < temp.Count; i++)
        {
            temp[i] = temp[i].ToLower();
        }

        for (int i = 0; i < temp.Count; i++)
        {
            if (temp[i].Length > 0)
            {
                temp[i] = char.ToUpper(temp[i][0]) + temp[i].Substring(1);
            }
        }

        for (int i = 0; i < temp.Count; i++)
        {
            answer += temp[i];
            if (i != temp.Count - 1)
                answer += ' ';
        }

        return answer;
    }
}