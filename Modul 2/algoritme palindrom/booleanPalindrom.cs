using System;

namespace algoritme_palindrom
{
    public class booleanPalindrom
    {
        public static bool isPalindrom(string str1, string str2)
        {
            int n = str1.Length;

            for (int i = 0; i < n; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
