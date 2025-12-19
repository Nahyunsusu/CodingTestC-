using System;

public class Solution
{
    public int solution(int hp)
    {
        int answer = 0;

        int num = 0;

        num = hp / 5;
        answer += num;
        hp = hp - num * 5;

        num = hp / 3;
        answer += num;
        hp = hp - num * 3;

        return answer + hp;
    }
}