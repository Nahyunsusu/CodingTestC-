using System;

public class Solution
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;

        // 1. 신청 금액이 적은 순서대로 정렬
        Array.Sort(d);

        // 2. 작은 금액부터 예산에서 차감
        foreach (int amount in d)
        {
            if (budget >= amount)
            {
                budget -= amount; // 예산 차감
                answer++;         // 지원 가능한 부서 수 증가
            }
            else
            {
                // 예산이 부족하면 더 이상 지원 불가 (정렬되어 있으므로 뒤는 볼 필요 없음)
                break;
            }
        }

        return answer;
    }
}