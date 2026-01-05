using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string myString)
    {
        List<int> answer = new List<int>();
        int count = 0;

        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'x')
            {
                answer.Add(count);
                count = 0;
            }
            else
            {
                count++;
            }
        }

        answer.Add(count);

        return answer.ToArray();
    }
}