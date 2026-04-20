using System;

class Solution
{
    private int[] numbers;
    private int answer = 0;

    public int solution(int[] nums)
    {
        numbers = nums;

        Combination(0, 0, 0);
        return answer;
    }

    private void Combination(int start, int count, int sum)
    {
        if (count == 3)
        {
            if (IsPrime(sum)) 
                answer++;
            return;
        }

        for (int i = start; i < numbers.Length; i++)
        {
            Combination(i + 1, count + 1, sum + numbers[i]);
        }
    }

    private bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}