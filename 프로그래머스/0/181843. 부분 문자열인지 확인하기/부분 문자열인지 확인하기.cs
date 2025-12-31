using System;

public class Solution
{
    public int solution(string my_string, string target)
    {
        if(my_string.Contains(target))
        {
            return 1;
        }

        return 0;
    }
}