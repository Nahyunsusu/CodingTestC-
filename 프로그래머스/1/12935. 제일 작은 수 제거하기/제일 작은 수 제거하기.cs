using System;
using System.Collections.Generic; 
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        if (arr.Length <= 1) return new int[] { -1 };

        List<int> list = arr.ToList();

        int minNum = list[0];
        int minNumIndex = 0;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < minNum)
            {
                minNum = list[i];
                minNumIndex = i;
            }
        }

        list.RemoveAt(minNumIndex);

        return list.ToArray();
    }
}