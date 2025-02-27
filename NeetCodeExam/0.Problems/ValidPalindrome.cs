using System;

namespace NeetCodeExam.Problems;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();

        string newS = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c < 'a' || c > 'z')
            {
                continue;
            }
            newS += c;
        }

        int left = 0;
        int right = newS.Length - 1;

        while (left < right)
        {
            if (newS[left] != newS[right])
            {
                return false;
            }

            left++;
            right--;
        }
        return true;
    }
}
