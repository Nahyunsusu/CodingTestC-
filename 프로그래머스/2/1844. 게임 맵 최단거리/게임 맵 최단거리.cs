using System;
using System.Collections.Generic;

public class Solution
{
    private int[,] temp;

    public int solution(int[,] maps)
    {
        temp = maps;

        PathFinder finder = new PathFinder();

        finder.SetSol(this);
        finder.MakeDir();

        return finder.BFS(maps);
    }

    public int[,] GetMaps() => temp;
}

public class PathFinder
{
    List<(int,int)> Directions = new List<(int,int)>();

    Solution sol = new Solution();

    public void SetSol(Solution sol)
    {
        this.sol = sol;
    }

    Tuple<int, int> curPlayer;
    Tuple<int, int> destination;

    public void MakeDir()
    {
        curPlayer = new Tuple<int, int>(0, 0);

        if(sol.GetMaps() != null)
        {
            destination = new Tuple<int, int>(sol.GetMaps().GetLength(0) - 1, sol.GetMaps().GetLength(1) - 1);
        }

        Directions.Add((+0, +1));
        Directions.Add((+0, -1));
        Directions.Add((+1, +0));
        Directions.Add((-1, +0));
    }

    public int BFS(int[,] maps)
    {
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);

        bool[,] visited = new bool[n, m];

        Queue<(int x, int y, int count)> q = new Queue<(int x, int y, int count)>();

        q.Enqueue((0, 0, 1));
        visited[0, 0] = true;

        while (q.Count > 0)
        {
            var cur = q.Dequeue();

            if (cur.x == n - 1 && cur.y == m - 1)
                return cur.count;

            foreach (var dir in Directions)
            {
                int nextX = cur.x + dir.Item1;
                int nextY = cur.y + dir.Item2;

                if (nextX >= 0 && nextX < n && nextY >= 0 && nextY < m && maps[nextX, nextY] == 1 && !visited[nextX, nextY])
                {
                    visited[nextX, nextY] = true;
                    q.Enqueue((nextX, nextY, cur.count + 1));
                }
            }
        }
        return -1;
    }
}