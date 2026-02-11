using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, bool[] flag)
    {
        Stack<int> answer = new Stack<int>();

        for(int i=0;i<arr.Length;i++)
        {
            if (flag[i] == true)
            {
                for(int j = 0; j < arr[i] * 2;j++)
                {
                    answer.Push(arr[i]);
                }
            }
            else
            {
                for(int j = 0; j < arr[i];j++)
                {
                    if(answer.Count != 0)
                        answer.Pop();
                }
            }
        }

        int[] result = answer.ToArray();
Array.Reverse(result);
return result;
    }
}