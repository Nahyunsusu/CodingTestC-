using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int[] answer = new int[] { };

        List<int> temp = new List<int>();

        temp.Add(n);

        while(true)
        {
            if (n == 1)
                break;

            if(n % 2 == 0)
            {
                n /= 2;
                temp.Add(n);
            }
            else
            {
                n = 3 * n + 1;
                temp.Add(n);
            }
        }


        return temp.ToArray();
    }
}