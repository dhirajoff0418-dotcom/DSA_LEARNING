public class Solution {
    public int MaximumLengthSubstring(string s) {
    var freq = new Dictionary<char, int>();

    int left = 0;
    int maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char ch = s[right];

        if (!freq.ContainsKey(ch))
            freq[ch] = 0;

        freq[ch]++;

        while (freq[ch] > 2)
        {
            char leftChar = s[left];

            freq[leftChar]--;
            left++;
        }

        maxLength = Math.Max(
            maxLength,
            right - left + 1
        );
    }

    return maxLength;
    }
}