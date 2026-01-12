using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        List<int> answer = num_list.ToList();

        for(int i=0;i<n;i++)
        {
            answer.Add(num_list[i]);
        }

        answer.RemoveRange(0, n);

        return answer.ToArray();
    }
}   