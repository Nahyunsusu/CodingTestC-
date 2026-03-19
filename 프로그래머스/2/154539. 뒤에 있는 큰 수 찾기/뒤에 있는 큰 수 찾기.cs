/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int n = numbers.Length;
        List<int> answer = new List<int>(new int[n]);

        for (int i = 0; i < n; i++)
        {
            int num = -1;

            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] > numbers[i])
                {
                    num = numbers[j];
                    break;
                }
            }

            answer[i] = num;
        }

        return answer.ToArray();
    }
}
*/

using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        int n = numbers.Length;
        int[] answer = new int[n];

        for (int i = 0; i < answer.Length; i++) answer[i] = -1;

        Stack<int> nums = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (nums.Count > 0 && numbers[nums.Peek()] < numbers[i])
            {
                int index = nums.Pop();
                answer[index] = numbers[i];
            }

            nums.Push(i);
        }

        return answer;
    }
}
