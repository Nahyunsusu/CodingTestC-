using System;

public class Solution {
    public int[] solution(int[] array) 
    {
        int[] answer = new int[2];
        
        int maxIndex = 0;
        int maxNum = array[0];
        
        for(int i=0;i<array.Length;i++)
        {
            if(array[i] > maxNum)
            {
                maxNum = array[i];
                maxIndex = i;
            }

        }
        
        answer[0] = maxNum;
        answer[1] = maxIndex;
        
        return answer;
    }
}