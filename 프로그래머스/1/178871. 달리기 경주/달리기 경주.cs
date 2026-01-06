using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
public class Solution
{
    public void Swap(List<string> temp, int index)
    {
        string aa = temp[index];

        temp[index] = temp[index - 1];
        temp[index - 1] = aa;
    }

    public string[] solution(string[] players, string[] callings)
    {
        Dictionary<string, int> answer = new Dictionary<string, int>();

        for(int i=0;i<players.Length;i++)
        {
            answer.Add(players[i], i);
        }

        for(int i=0;i<callings.Length;i++)
        {
            int temp = answer[callings[i]];

            int front = temp - 1;
            string frontPlayer = players[front];

            players[front] = callings[i];
            players[temp] = frontPlayer;

            answer[callings[i]] = front;
            answer[frontPlayer] = temp;
        }

        return players;
    }

  

}