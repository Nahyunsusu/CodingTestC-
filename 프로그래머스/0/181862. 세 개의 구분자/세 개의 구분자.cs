using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string[] solution(string myStr)
    {
        string[] separators = new string[] { "a", "b", "c" };

        string[] result = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (result.Length == 0) 
            return new string[] { "EMPTY" };

        return result;
    }
}