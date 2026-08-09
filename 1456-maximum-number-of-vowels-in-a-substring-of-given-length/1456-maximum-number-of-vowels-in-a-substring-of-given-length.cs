public class Solution
{
    bool IsVowel(char ch)
    {
        return "aeiouAEIOU".Contains(ch);
    }

    public int MaxVowels(string s, int k)
    {
        int i = 0;
        int j = 0;
        int currVowels = 0;
        int maxVowels = 0;

        while (j < s.Length)
        {
            if (IsVowel(s[j]))
            {
                currVowels++;
            }

            if (j - i + 1 == k)
            {
                maxVowels = Math.Max(maxVowels, currVowels);

                if (IsVowel(s[i]))
                {
                    currVowels--;
                }

                i++;
            }

            j++;
        }

        return maxVowels;
    }
}