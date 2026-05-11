using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string before, string after)
    {
        string sortedBefore = string.Concat(before.OrderBy(c => c));
        string sortedAfter  = string.Concat( after.OrderBy(c => c));

        return sortedBefore == sortedAfter ? 1 : 0;
    }
}