using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int answer = array[0];
        int num = Math.Abs(array[0] - n);

        for (int i = 1; i < array.Length; i++)
        {
            int temp = Math.Abs(array[i] - n);

            if (temp < num)
            {
                num = temp;
                answer = array[i];
            }
            else if (temp == num)
            {
                if (array[i] < answer)
                {
                    answer = array[i];
                }
            }
        }
        return answer;
    }
}