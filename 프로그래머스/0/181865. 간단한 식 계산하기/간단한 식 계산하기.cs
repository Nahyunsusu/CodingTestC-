using System;

public class Solution
{
    public int solution(string binomial)
    {
        int answer = 0;

        string[] temp = binomial.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int a = int.Parse(temp[0]);
        int b = int.Parse(temp[2]);

        if (temp[1] == "*")
        {
            return a * b;
        }

        if (temp[1] == "+")
        {
            return a + b;
        }

        if (temp[1] == "-")
        {
            return a - b;
        }

        return answer;
    }
}