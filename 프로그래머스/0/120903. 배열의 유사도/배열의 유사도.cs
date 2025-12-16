using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] s1, string[] s2)
    {
        int answer = 0;
        HashSet<string> set1 = new HashSet<string>();

        for(int i=0;i<s1.Length;i++)
        {
            set1.Add(s1[i]);
        }

        bool check = false;

        for(int i=0;i<s2.Length;i++)
        {
            check = set1.Contains(s2[i]);
            if (check)
                answer++;
        }

        return answer;
    }
}