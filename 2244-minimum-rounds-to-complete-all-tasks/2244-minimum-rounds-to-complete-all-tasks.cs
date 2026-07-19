public class Solution {
    public int MinimumRounds(int[] tasks) {

        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int task in tasks)
        {
            if (freq.ContainsKey(task))
                freq[task]++;
            else
                freq[task] = 1;
        }

        int rounds = 0;

        foreach (var item in freq)
        {
            int count = item.Value;

            if (count == 1)
                return -1;

            rounds += (count + 2) / 3;
        }

        return rounds;
    }
}