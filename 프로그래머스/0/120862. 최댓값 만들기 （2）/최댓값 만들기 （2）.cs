using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        Array.Sort(numbers);

        int a = 0, b = 0;

        a = numbers[0] * numbers[1];

        b = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

        return a > b ? a : b ;
    }
}