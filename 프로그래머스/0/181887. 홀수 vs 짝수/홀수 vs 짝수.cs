using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int num1 = 0, num2 = 0;
        for(int i=0;i<num_list.Length;i+=2)
        {
            num1 += num_list[i];
        }

        for (int i = 1; i < num_list.Length; i += 2)
        {
            num2 += num_list[i];
        }

        return Math.Max(num1, num2);
    }
}