using System;

public class Solution
{
    public int solution(int num, int k)
    {
        int answer = 0;
        string aa = k.ToString();
        string temp = num.ToString();

        int index = temp.IndexOf(aa);

        return index != -1 ? index +1 : -1;
    }
}