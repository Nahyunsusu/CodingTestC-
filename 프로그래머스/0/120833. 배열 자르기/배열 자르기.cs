using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers, int num1, int num2)
    {
        int length = num2 - num1 + 1;

        int[] answer = new int[length];

        for(int i=num1;i<num2;i++)
        {
            Array.Copy(numbers, num1, answer, 0, length);
        }

        return answer;
    }
}