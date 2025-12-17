using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int product = 1; 
        int     sum = 0;     

        foreach (int num in num_list)
        {
            product *= num;
            sum     += num;
        }

        return (sum * sum > product) ? 1 : 0;
    }

}