using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int n, int[] slicer, int[] num_list)
    {
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];

        int[] answer;
        int startIndex = 0;
        int length = 0;

        if(n==1)
        {
            startIndex = 0;
            length = b+1;
            answer = new int[length];
            Array.Copy(num_list, startIndex, answer, 0, length);
        }

        else if(n == 2)
        {
            startIndex = a;
            length = num_list.Length - a;
            answer = new int[length];
            Array.Copy(num_list, startIndex, answer, 0, length);
        }

        else if(n==3)
        {
            startIndex = a;
            length = b - a + 1;
            answer = new int[length];
            Array.Copy(num_list, startIndex, answer, 0, length);
        }

        else
        {
            length = (b - a) / c + 1;
            answer = new int[length];
            for (int i = 0; i < length; i++)
            {
                answer[i] = num_list[a + (i * c)];
            }
        }

        return answer;
    }
}