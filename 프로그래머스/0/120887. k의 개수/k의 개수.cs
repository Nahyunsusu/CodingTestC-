using System;

public class Solution {
    public int solution(int i, int j, int k) {
       int answer = 0;

string compare = k.ToString();

for(int a = i;a<=j;a++)
{
    string temp = a.ToString();

    foreach (char c in temp)
    {
        if (c.ToString() == compare)
        {
            answer++;
        }
    }
}

return answer;
    }
}