using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        // Split(' ')을 하면 연속된 공백은 ""(빈 문자열)로 들어옵니다.
        List<string> temp = s.Split(' ').ToList();

        for (int i = 0; i < temp.Count; i++)
        {
            // 1. ToLower()는 결과를 반환하므로 다시 할당해야 함
            temp[i] = temp[i].ToLower();
        }

        for (int i = 0; i < temp.Count; i++)
        {
            // 2. 빈 문자열이 아닐 때만 첫 글자를 대문자로 변경
            // 숫자는 ToUpper를 써도 그대로 유지되므로 알파벳 체크 생략 가능
            if (temp[i].Length > 0)
            {
                temp[i] = char.ToUpper(temp[i][0]) + temp[i].Substring(1);
            }
        }

        for (int i = 0; i < temp.Count; i++)
        {
            answer += temp[i];
            if (i != temp.Count - 1)
                answer += ' ';
        }

        return answer;
    }
}