public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Store frequency of magazine characters
        foreach (char ch in magazine)
        {
            if (freq.ContainsKey(ch))
            {
                freq[ch]++;
            }
            else
            {
                freq[ch] = 1;
            }
        }

        // Check ransomNote
        foreach (char ch in ransomNote)
        {
            if (!freq.ContainsKey(ch) || freq[ch] == 0)
            {
                return false;
            }

            freq[ch]--;
        }

        return true;
    }
}