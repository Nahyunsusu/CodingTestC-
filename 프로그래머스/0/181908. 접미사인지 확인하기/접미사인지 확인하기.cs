using System;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {

        string temp = "";
        if(my_string.Length - is_suffix.Length >= 0)
        {
           temp = my_string.Substring(my_string.Length - is_suffix.Length);

        }

        return temp == is_suffix ? 1 : 0;
    }

}