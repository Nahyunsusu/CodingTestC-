using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        string temp = "";

        for (int i = 0; i < my_string.Length; i++)
        {
            if (char.IsDigit(my_string[i]))
            {
                temp += my_string[i];
            }
            else
            {
                if (!string.IsNullOrEmpty(temp))
                {
                    answer += int.Parse(temp);
                    temp = "";
                }
            }
        }

        if (!string.IsNullOrEmpty(temp))
        {
            answer += int.Parse(temp);
        }

        return answer;
    }
}