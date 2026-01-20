using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string my_string)
    {
        char[] temp = my_string.ToLower().ToArray();
        Array.Sort(temp);
        
        return new string(temp);
    }
}