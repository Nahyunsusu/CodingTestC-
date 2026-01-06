using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(string dirs)
    {
        int answer = 0;

        int x = 0, y = 0;

        List<(int ax, int ay, int bx, int by)> nums = new List<(int ax, int ay, int bx, int by)>();

        for(int i=0;i<dirs.Length;i++)
        {
            int prevX = x;
            int prevY = y;

            if(dirs[i] == 'U')
            {
                y++;
            }
            if (dirs[i] == 'D')
            {
                y--;
            }
            if (dirs[i] == 'R')
            {
                x++;
            }
            if (dirs[i] == 'L')
            {
                x--;
            }

            if (x < -5 || x > 5 || y < -5 || y > 5)
            {
                x = prevX;
                y = prevY;
                continue;
            }

            if (!(nums.Contains((prevX, prevY, x, y)) || nums.Contains((x, y, prevX, prevY))))
            {
                nums.Add((x, y, prevX, prevY));
            }
        }

        return nums.Count;
    }
}