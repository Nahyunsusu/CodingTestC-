using System;

public class Solution
{
    public int[] solution(int n, int[] numlist)
    {
        int[] answer = new int[numlist.Length];

        int currentNum = 0;

        foreach (int num in numlist)
        {
            if(num % n == 0)
            {
                answer[currentNum] = num;
                currentNum++;
            }
        }

        Array.Resize(ref answer, currentNum);

        return answer;
    }
}