using System;

public class Solution
{
    public string solution(string my_string)
    {
        char[] chars = my_string.ToCharArray();

        for(int i=0;i<my_string.Length;i++)
        {
            // 대문자일때
            if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                chars[i] = char.ToLower(chars[i]);
            }
            else
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }

        return new string(chars);
    }
}