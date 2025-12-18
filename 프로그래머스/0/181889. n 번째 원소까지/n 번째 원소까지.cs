using System;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        int[] answer = new int[n];

        Array.Copy(num_list, answer, n);

        return answer;
    }
}