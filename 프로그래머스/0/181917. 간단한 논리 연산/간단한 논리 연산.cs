using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool answer = true;

        bool temp1 = x1 | x2;
        bool temp2 = x3 | x4;

        if (temp1 && temp2)
            answer = true;
        else
            answer = false;

        return answer;
    }
}