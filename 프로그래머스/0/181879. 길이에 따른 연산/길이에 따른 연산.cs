using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;

        if (num_list.Length > 10)
        {
            foreach (int i in num_list)
            {
                answer = answer + i;
            }

            return answer;
        }

        answer = 1;

        foreach(int i in num_list)
        {
            answer =answer* i;
        }
        return answer;
    }
}