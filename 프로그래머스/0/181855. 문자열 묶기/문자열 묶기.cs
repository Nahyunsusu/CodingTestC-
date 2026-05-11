using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] strArr)
    {
        int maxCount = 0;

        Dictionary<int, int> counts = new Dictionary<int, int>();

        for(int i=0;i<strArr.Length;i++)
        {
            int length = strArr[i].Length;

            if (!counts.ContainsKey(length))
            {
                counts[length] = 0;
            }

            counts[strArr[i].Length]++;
            if(maxCount < counts[strArr[i].Length])
            {
                maxCount = counts[strArr[i].Length];
            }
        }
    
        return maxCount;
    }
}