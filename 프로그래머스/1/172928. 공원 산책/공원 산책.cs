using System;
using System.ComponentModel;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        List<Routes> newRoute = new List<Routes>(routes.Length);

        for(int i=0;i<routes.Length;i++)
        {
            int temp = routes[i][2] - '0';
            switch (routes[i][0])
            {
                case 'E':
                    int tempE = routes[i][2] - '0';
                    Routes routesE = new Routes(6, tempE);
                    newRoute.Add(routesE);
                    break;
                case 'W':
                    int tempW = routes[i][2] - '0';
                    Routes routesW = new Routes(4, tempW);
                    newRoute.Add(routesW);
                    break;
                case 'N':
                    int tempN = routes[i][2] - '0';
                    Routes routesN = new Routes(8, tempN);
                    newRoute.Add(routesN);
                    break;
                case 'S':
                    int tempS = routes[i][2] - '0';
                    Routes routesS = new Routes(2, tempS);
                    newRoute.Add(routesS);
                    break;
            }

        }

        int[,] map = new int[park[0].Length,park.Length];

        List<int> startNum = new List<int>();

        for(int i = 0; i < map.GetLength(0);i++)
        {
            for(int j = 0; j < map.GetLength(1);j++)
            {
                switch (park[j][i])
                {
                    case 'S':
                        map[i, j] = 2;
                        startNum.Add(i);
                        startNum.Add(j);
                        break;
                    case 'O':
                        map[i, j] = 1;
                        break;
                    case 'X':
                        map[i, j] = 0;
                        break;
                }
            }
        }

        for (int i = 0; i < routes.Length; i++)
        {
            bool canMove = true;
            int curX = startNum[0];
            int curY = startNum[1];

            if (newRoute[i].direction == 6)
            {
                for (int j = 1; j <= newRoute[i].step; j++)
                {
                    if (curX + j >= map.GetLength(0) || map[curX + j, curY] == 0)
                    {
                        canMove = false;
                        break;
                    }
                }
                if (canMove) 
                    startNum[0] += newRoute[i].step;
            }

            if (newRoute[i].direction == 4)
            {
                for (int j = 1; j <= newRoute[i].step; j++)
                {
                    if (curX - j < 0 || map[curX - j, curY] == 0)
                    {
                        canMove = false;
                        break;
                    }
                }
                if (canMove) 
                    startNum[0] -= newRoute[i].step;
            }

            if (newRoute[i].direction == 8)
            {
                for (int j = 1; j <= newRoute[i].step; j++)
                {
                    if (curY - j < 0 || map[curX, curY - j] == 0)
                    {
                        canMove = false;
                        break;
                    }
                }
                if (canMove) 
                    startNum[1] -= newRoute[i].step;
            }

            if (newRoute[i].direction == 2)
            {
                for (int j = 1; j <= newRoute[i].step; j++)
                {
                    if (curY + j >= map.GetLength(1) || map[curX, curY + j] == 0)
                    {
                        canMove = false;
                        break;
                    }
                }
                if (canMove) 
                    startNum[1] += newRoute[i].step;
            }
        }

        return new int[] { startNum[1], startNum[0] };
    }
    
    public struct Routes
    {
        public Routes(int dir, int step)
        {
            this.direction = dir;
            this.step = step;
        }
        public int direction;
        public int step;
    }

}