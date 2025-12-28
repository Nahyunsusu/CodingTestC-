    using System;

    public class Solution
    {
        public int solution(string my_string, string is_prefix)
        {
            if (is_prefix.Length > my_string.Length)
                return 0;

            char[] temp = new char[is_prefix.Length];

            my_string.CopyTo(0, temp, 0, is_prefix.Length);

            string result = new string(temp);

            return result == is_prefix ? 1 : 0;
        }
    }