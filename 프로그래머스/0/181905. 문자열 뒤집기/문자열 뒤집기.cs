using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string front = my_string.Substring(0, s);

        string middle = my_string.Substring(s, e - s + 1);
        char[] charArray = middle.ToCharArray();
        Array.Reverse(charArray);
        string rev = new string(charArray);

        string back = my_string.Substring(e + 1);

        return front + rev + back;
    }
}