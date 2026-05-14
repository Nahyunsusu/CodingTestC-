using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int firstIdx = Array.IndexOf(arr, 2);
        int  lastIdx = Array.LastIndexOf(arr, 2);

        if (firstIdx == -1)
        {
            return new int[] { -1 };
        }

        int length = lastIdx - firstIdx + 1;
        int[] answer = new int[length];
        Array.Copy(arr, firstIdx, answer, 0, length);

        return answer;
    }
}