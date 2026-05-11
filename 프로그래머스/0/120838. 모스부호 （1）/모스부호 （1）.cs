using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public Dictionary<string, string> morse = new Dictionary<string, string>
    {
        {".-", "a"}, {"-...", "b"}, {"-.-.", "c"}, {"-..", "d"}, {".", "e"},
        {"..-.", "f"}, {"--.", "g"}, {"....", "h"}, {"..", "i"}, {".---", "j"},
        {"-.-", "k"}, {".-..", "l"}, {"--", "m"}, {"-.", "n"}, {"---", "o"},
        {".--.", "p"}, {"--.-", "q"}, {".-.", "r"}, {"...", "s"}, {"-", "t"},
        {"..-", "u"}, {"...-", "v"}, {".--", "w"}, {"-..-", "x"}, {"-.--", "y"},
        {"--..", "z"}
    };

    public string solution(string letter)
    {
        string answer = "";

        string[] temp = letter.Split(" ");

        for(int i=0;i<temp.Length;i++)
        {
            answer += morse[temp[i]];
        }

        return answer;
    }
}