using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string my_string)
    {

        List<int> temp = new List<int>();

        for(int i=0;i<my_string.Length;i++)
        {
            if (my_string[i] >= '0' && my_string[i] <='9')
            {
                temp.Add(my_string[i] - '0');
            }
        }

        temp.Sort();

        return temp.ToArray();
    }
}