using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers, string direction)
    {
        List<int> answer = numbers.ToList();

        if(direction == "left")
        {
            answer.Add(answer[0]);
            answer.RemoveAt(0);
        }

        else 
        {
            int last = answer[answer.Count - 1];
            answer.RemoveAt(answer.Count - 1);
            answer.Insert(0, last);
        }

            return answer.ToArray();
    }
}