using System.Collections.Generic;

public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += ' ';
                continue;
            }    

            char offset = char.IsUpper(s[i]) ? 'A' : 'a';
            char shifted = (char)((s[i] - offset + n) % 26 + offset);
            answer += shifted;
        }

        return answer;
    }
}