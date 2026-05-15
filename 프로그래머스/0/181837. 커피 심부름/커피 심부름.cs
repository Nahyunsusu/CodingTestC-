using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;

        string[] ame = { "iceamericano", "americanoice", "hotamericano", "americanohot", "americano", "anything" };

        for(int i=0;i<order.Length;i++)
        {
            if (ame.Contains(order[i]))
            {
                answer += 4500;
            }
            else
                answer += 5000;

        }

        return answer;
    }
}