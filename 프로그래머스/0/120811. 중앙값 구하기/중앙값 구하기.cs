using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;

        Array.Sort(array);

        int num = array.Length / 2;

        return array[num];
    }
}