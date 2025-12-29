using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        string newPat = "";

        for(int i=0;i<pat.Length;i++)
        {
            if (pat[i] == 'A')
                newPat += 'B';
            else
            {
                newPat += 'A';
            }
        }

        return myString.IndexOf(newPat) != -1 ? 1 : 0;
    }
}