using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        HashSet<char> trash = new HashSet<char>();
        HashSet<char>   use = new HashSet<char>();

        for(int i=0;i<s.Length;i++)
        {
            if (trash.Contains(s[i]))
                continue;

            if (use.Contains(s[i]))
            {
                trash.Add(s[i]);
                use.Remove(s[i]);
                continue;
            }

            use.Add(s[i]);
        }

        List<char> sortedList = use.ToList();
        sortedList.Sort();

        return new string(sortedList.ToArray());
    }
}