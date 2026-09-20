public class Solution {
    public int ReverseDegree(string s) {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        for (int i = 0; i < 26; i++) {
            letters[(char)('a' + i)] = 26 - i;
        }

        int sum = 0;
        for (int i = 0; i < s.Length; i++) {
            sum += letters[s[i]] * (i + 1);
        }
        return sum;
    }
}