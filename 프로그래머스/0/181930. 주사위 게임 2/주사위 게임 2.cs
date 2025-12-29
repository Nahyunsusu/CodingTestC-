using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int a, int b, int c)
    {
        int count = new HashSet<int> { a, b, c }.Count;

        int sum1 = a + b + c;
        int sum2 = a * a + b * b + c * c;
        int sum3 = a * a * a + b * b * b + c * c * c;

        if (count == 1) return sum1 * sum2 * sum3;
        if (count == 2) return sum1 * sum2;
        
        return sum1;
    }
}