public class Solution
{
    public string solution(int n)
    {
        string temp = "수박";

        string answer = "";

        for(int i=0;i<n;i++)
        {
            if(i%2==0)
            {
                answer += temp[0];
            }
            else
            {
                answer += temp[1];
            }
        }

        return answer;
    }
}