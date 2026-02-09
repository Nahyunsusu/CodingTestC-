using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(long n)
    {
        List<int> answer = new List<int>();

        string temp = n.ToString();

        for (int i = 0; i < temp.Length; i++)
        {
            answer.Add(temp[i] - '0');
        }

        answer.Reverse();

        return answer.ToArray();
    }
}