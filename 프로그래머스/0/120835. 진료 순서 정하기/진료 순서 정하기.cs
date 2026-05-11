using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] emergency)
    {
        var sorted = emergency.OrderByDescending(x => x).ToList();

        return emergency.Select(x => sorted.IndexOf(x) + 1).ToArray();
    }
}