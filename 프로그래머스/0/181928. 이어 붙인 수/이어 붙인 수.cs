using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;

        string even = "", odd = "";

        foreach(int num in num_list)
        {
            if(num %2 == 0)
            {
                even += num.ToString();
            }
            else
            {
                odd += num.ToString();
            }
        }

        answer = int.Parse(even) + int.Parse(odd);

        return answer;
    }
}