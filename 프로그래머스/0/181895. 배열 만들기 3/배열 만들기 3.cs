using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        List<int> answer = new List<int>();

        for(int i= 0;i<intervals.GetLength(0);i++)
        {
            int start = intervals[i, 0];
            int   end = intervals[i, 1];
            int count = end - start +1;

            answer.AddRange(arr.Skip(start).Take(count));
        }

        return answer.ToArray();
    }
}