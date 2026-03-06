public class Solution
{
    public bool solution(string s)
    {
        bool answer = false;

        if (s.Length == 4 || s.Length == 6)
        {
            foreach(var c in s)
            {
                if (c > '9' || c < '0')
                    return false;
            }
            answer = true;
        }


        return answer;
    }
}