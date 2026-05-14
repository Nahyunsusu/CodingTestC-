using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;

        for(int i=0;i<array.Length;i++)
        {
            string temp = array[i].ToString();

            for(int j=0;j<temp.Length;j++)
            {
                if (temp[j] == '7')
                    answer++;
            }
        }

        return answer;
    }
}