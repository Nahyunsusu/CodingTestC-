using System;

public class Solution
{
    public int solution(int[] dot)
    {
        bool x, y;

        if (dot[0] > 0 && dot[1] > 0)
            return 1;

        if (dot[0] > 0 && dot[1] < 0)
            return 4;

        if (dot[0] < 0 && dot[1] > 0)
            return 2;

        if (dot[0] < 0 && dot[1] < 0)
            return 3;

        return 0;
    }
}