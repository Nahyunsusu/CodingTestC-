using System;

public class Solution
{
    public string solution(string n_str)
    {
        int num = 0;

        for (int i = 0; i < n_str.Length; i++)
        {
            if (n_str[i] != '0')
            {
                num = i;
                break;
            }
        }

        return n_str.Substring(num);
    }
}