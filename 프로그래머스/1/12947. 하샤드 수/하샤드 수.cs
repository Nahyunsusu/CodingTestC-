public class Solution
{
    public bool solution(int x)
    {
        string temp = x.ToString();
        int sum = 0;

        for (int i = 0; i < temp.Length; i++)
        {
            sum += temp[i] - '0';
        }

        if (x % sum == 0)
            return true;

        return false;
    }
}