public class Solution {
    public int MinDeletions(string s) {
        int[] frequency = new int[26];

        foreach (char c in s)
        {
            frequency[c - 'a']++;
        }

        int opCount = 0;
        HashSet<int> set = new();

        for (int i = 0; i < 26; i++)
        {
            while (frequency[i] > 0 && set.Contains(frequency[i]))
            {
                frequency[i]--;
                opCount++;
            }

            if (frequency[i] > 0)
                set.Add(frequency[i]);
        }

        return opCount;
    }
}