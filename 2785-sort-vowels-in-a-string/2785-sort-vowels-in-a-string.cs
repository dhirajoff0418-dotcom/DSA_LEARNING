public class Solution
{
    public string SortVowels(string s)
    {
        List<char> vowels = new List<char>();

        foreach (char c in s)
        {
            if (IsVowel(c))
                vowels.Add(c);
        }

        vowels.Sort();

        char[] chars = s.ToCharArray();
        int index = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (IsVowel(chars[i]))
            {
                chars[i] = vowels[index];
                index++;
            }
        }

        return new string(chars);
    }

    private bool IsVowel(char c)
    {
        return "aeiouAEIOU".Contains(c);
    }
}