using System;
using System.Text;
using System.Collections.Generic;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        HashSet<int> HS = new HashSet<int>(indices);
        StringBuilder sb = new StringBuilder();

        for(int i=0;i<my_string.Length;i++)
        {
            if (!HS.Contains(i))
            {
                sb.Append(my_string[i]);
            }
        }

        return sb.ToString();
    }
}