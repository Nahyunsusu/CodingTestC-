using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> answer = numbers.ToList();

        for(int i=0;i<answer.Count;i++)
        {
            answer[i] *= 2;
        }

        return answer.ToArray();
    }
}