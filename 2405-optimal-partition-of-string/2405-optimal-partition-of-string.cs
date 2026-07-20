public class Solution {
    public int PartitionString(string s) {
        int[] lastIdx = new int[26];
        Array.Fill(lastIdx, -1);
        int res = 1, start = 0;
        for (int i = 0; i < s.Length; i++) {
            int j = s[i] - 'a';
            if (lastIdx[j] >= start) {
                start = i;
                res++;
            }
            lastIdx[j] = i;
        }
        return res;
    }
}