using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n)
    {
        int answer = 1;
        int count = 1;

        while(true)
        {
            answer *= count;
            count++;

            if(answer > n)
            {
                count--;
                count--;
                break;
            }
        }

        return count;
    }
}