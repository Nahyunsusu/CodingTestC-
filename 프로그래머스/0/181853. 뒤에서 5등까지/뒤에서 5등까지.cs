    using System;

    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            Array.Sort(num_list);

            int[] answer = new int[5];

            //num_list.CopyTo(answer, 1);
            Array.Copy(num_list, answer, 5);

            return answer;
        }
    }