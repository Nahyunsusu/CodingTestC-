using System;

public class Solution
{
    private int[] _number;
    private int _answer = 0;

    public int solution(int[] number)
    {
        _number = number;
        FindThree(0, 0, 0);
        return _answer;
    }

    private void FindThree(int start, int count, int sum)
    {
        if (count == 3)
        {
            if (sum == 0) _answer++;
            return;
        }

        for (int i = start; i < _number.Length; i++)
        {
            FindThree(i + 1, count + 1, sum + _number[i]);
        }
    }
}