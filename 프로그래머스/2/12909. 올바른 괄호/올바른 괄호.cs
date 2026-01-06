using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool solution(string s)
    {
        Stack<char> temp = new Stack<char>();

        for(int i=0;i<s.Length;i++)
        {
            if (s[i] == '(')
            {
                temp.Push('(');
            }
            else
            {
                if (temp.Count < 1)
                    return false;
                temp.Pop();
            }
        }

        if (temp.Count == 0)
            return true;

        return false;
    }
}