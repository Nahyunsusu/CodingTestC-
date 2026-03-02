using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 1;

        for (int index = 0; index < s.Length; index++)
        {
            for (int i = 1; ; i++)
            {
                int left  = index - i;
                int right = index + i;

                if (left < 0 || right >= s.Length || s[left] != s[right]) 
                    break;

                if (answer < (2 * i) + 1)
                {
                    answer = (2 * i) + 1;
                }
            }

            for (int i = 0; ; i++)
            {
                int left  = index - i;
                int right = index + i + 1; 

                if (left < 0 || right >= s.Length || s[left] != s[right]) 
                    break;

                if (answer < (2 * i) + 2)
                {
                    answer = (2 * i) + 2;
                }
            }
        }

        return answer;
    }
}