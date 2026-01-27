using System;
using System.Collections.Generic;

public class Solution
{
    public long[] solution(int x, int n)
    {
        List<long> answer = new List<long>();
        long temp = 0;

        for(int i=0;i<n;i++)
        {
            temp += x;
            answer.Add(temp);
        }

        return answer.ToArray();
    }
}