using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string temp = my_string.Substring(my_string.Length - n);

        return temp;
    }
}