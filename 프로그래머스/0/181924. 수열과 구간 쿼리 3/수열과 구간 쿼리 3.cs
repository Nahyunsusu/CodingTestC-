using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        List<int> answer = arr.ToList();

        for (int i = 0; i < queries.GetLength(0);i++)
        {
            int temp = answer[queries[i, 0]];
            answer[queries[i, 0]] = answer[queries[i, 1]];
            answer[queries[i, 1]] = temp;
        }

        return answer.ToArray();
    }
}