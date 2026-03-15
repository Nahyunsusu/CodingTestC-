using System;
using System.Linq;
public class Solution
{
    public int solution(int n)
    {
        string str = "";

        while (n > 0)
        {
            str += (n % 3).ToString();
            n /= 3;
        }

        int count = 1;
        int answer = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            int currentDigit = str[i] - '0';
            answer += currentDigit * count;

            count *= 3;
        }

        return answer;
    }
}