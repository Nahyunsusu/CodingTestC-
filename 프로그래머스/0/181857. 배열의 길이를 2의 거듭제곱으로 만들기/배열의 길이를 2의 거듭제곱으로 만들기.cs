using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {

        int num = 1;

        while(true)
        {
            if (arr.Count() > num)
            {
                num *= 2;
            }
            else
                break;
        }

        int[] answer = new int[num];

        for(int i=0;i<arr.Count();i++)
        {
            answer[i] = arr[i];
        }

        return answer;
    }
}