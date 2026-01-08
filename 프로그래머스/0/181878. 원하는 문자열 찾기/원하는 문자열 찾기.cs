using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;

        pat = pat.ToLower();
        myString = myString.ToLower();



        return myString.Contains(pat) ? 1: 0;
    }
}