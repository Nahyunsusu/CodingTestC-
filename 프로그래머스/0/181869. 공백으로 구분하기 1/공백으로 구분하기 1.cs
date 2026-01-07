using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string my_string)
    {
        List<string> answer = new List<string>();

        string temp = "";

        for(int i=0;i<my_string.Length;i++)
        {
            if (my_string[i] != ' ')
            {
                temp += my_string[i];
            }
            else 
            {
                if(temp.Length > 0)
                {
                    answer.Add(temp);
                    temp = string.Empty;
                }
            }

        }

        if (temp.Length > 0)
        {
            answer.Add(temp);
        }

        return answer.ToArray();
    }
}