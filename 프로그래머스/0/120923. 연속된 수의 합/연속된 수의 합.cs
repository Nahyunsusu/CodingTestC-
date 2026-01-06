using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int num, int total)
    {
        List<int> answer = new List<int>();


        if(num %2 == 0)
        {
            int temp = total / num;

            for (int i = temp - num / 2 +1; i <= temp + num / 2; i++)
            {
                answer.Add(i);
            }
        }

        else 
        {
            int temp = total / num;
            
            for(int i=temp - num/2;i<=temp + num/2;i++)
            {
                answer.Add(i);
            }
        }

            return answer.ToArray();
    }
}