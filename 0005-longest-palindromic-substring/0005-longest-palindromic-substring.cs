public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0, maxLen = 1;

        for (int i = 0; i < s.Length; i++) {
            int lenOdd = Expand(s, i, i);       // odd length center (single char)
            int lenEven = Expand(s, i, i + 1); // even length center (gap)

            int currMax = Math.Max(lenOdd, lenEven);
            if (currMax > maxLen) {
                maxLen = currMax;
                start = i - (currMax - 1) / 2;
            }
        }

        return s.Substring(start, maxLen);
    }

    private int Expand(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left - 1;
    }
}