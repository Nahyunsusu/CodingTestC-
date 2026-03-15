using System;
public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];

        int max = Math.Max(n, m);
        int min = Math.Min(n, m);

        while(min != 0)
        {
            int temp = max % min;
            max = min;
            min = temp;
        }

        int answer1 = max;
        int answer2 = (n * m) / max;

        answer[0] = answer1;
        answer[1] = answer2;

        return answer;
    }
}