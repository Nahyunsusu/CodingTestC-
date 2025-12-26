using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string)
    {
        List<char> list = new List<char>();

        for(int i=0;i<my_string.Length;i++)
        {
            char temp = my_string[i];

            if (my_string[i] >= 'A' && my_string[i] <= 'Z')
            {
                temp = (char)(temp + 32);
            }
            list.Add(temp);

        }

        list.Sort();

        return new string(list.ToArray());
    }
}