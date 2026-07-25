public class Solution
{
    public int CountVowels(char[] ch)
    {
        int count = 0;

        foreach (char c in ch)
        {
            char x = char.ToLower(c);

            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                count++;
            }
        }

        return count;
    }

    public bool HalvesAreAlike(string s)
    {
        int mid = s.Length / 2;

        char[] leftHalf = s.Substring(0, mid).ToCharArray();
        char[] rightHalf = s.Substring(mid).ToCharArray();

        return CountVowels(leftHalf) == CountVowels(rightHalf);
    }
}