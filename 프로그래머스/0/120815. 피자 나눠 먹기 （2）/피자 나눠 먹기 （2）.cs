using System;

public class Solution
{
    public int solution(int n)
    {
        int pizzaCount = 1;

        while (true)
        {
            int count = pizzaCount * 6;

            if (count % n == 0)
                return pizzaCount;

            pizzaCount++;
        }

        return 0;
    }
}