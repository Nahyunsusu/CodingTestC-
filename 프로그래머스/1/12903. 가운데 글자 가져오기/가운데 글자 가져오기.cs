public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        if(s.Length % 2 == 0) // 짝수일 때
        {
            int num = s.Length / 2;
            answer += s[num -1];
            answer += s[num];
        }

        else // 홀수 일때
        {
            int num = s.Length / 2;
            answer += s[num];
        }

        return answer;
    }
}