using System;
using System.Linq;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int arr1Sum = arr1.Sum(), arr2Sum = arr2.Sum();

        if(arr1.Length == arr2.Length)
        {
            if (arr1Sum == arr2Sum)
                return 0;

            return arr1Sum > arr2Sum ? 1 : -1;
        }

        return arr1.Length > arr2.Length ? 1 : -1;
    }
}