using System;

public class Example
{
    public static void Main()
    {
        string s;

        Console.Clear();
        s = Console.ReadLine();

        string temp = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                temp += (char)(s[i] - 32);
            }
            else
            {
                temp += (char)(s[i] + 32);
            }
            
        }

        Console.WriteLine(temp);
    }
}