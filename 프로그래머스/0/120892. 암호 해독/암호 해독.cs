using System.Text;

public class Solution
{
    public string solution(string cipher, int code)
    {
        string temp = "";

        for (int i = code - 1; i < cipher.Length; i += code)
        {
            temp += cipher[i];
        }

        return temp;
    }
}