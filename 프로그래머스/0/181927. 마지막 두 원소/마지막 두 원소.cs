using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[num_list.Length + 1];

        Array.Copy(num_list, answer, num_list.Length);

        int last = num_list[num_list.Length - 1];
        int prev = num_list[num_list.Length - 2];

        answer[answer.Length - 1] =
            last > prev ? last - prev : last * 2;

        return answer;
    }

}