using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        int[]   answer = new int[progresses.Length];
        int[] checkDay = new int[progresses.Length];

        for (int i = 0; i < progresses.Length; ++i)
        {
            int day = 1;
            while (progresses[i] + speeds[i] * day < 100)
            {
                day++;
            }
            checkDay[i] = day;
        }

        int val = checkDay[0];
        int count = 1;
        int index = 0;

        for (int i = 0; i < progresses.Length; ++i)
        {
            if (i == progresses.Length - 1)
            {
                answer[index++] = count;
            }
            else if (checkDay[i + 1] <= val)
            {
                count++;
            }
            else
            {
                answer[index++] = count;
                count = 1;
                val = checkDay[i + 1];
            }
        }
        return answer.Where(x => x != 0).ToArray();
    }
}