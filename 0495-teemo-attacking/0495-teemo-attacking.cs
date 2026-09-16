public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int total = 0;

        for (int i = 0; i < timeSeries.Length; i++) {
            if (i == timeSeries.Length - 1) {
                total += duration;
            }
            else {
                total += Math.Min(duration, timeSeries[i + 1] - timeSeries[i]);
            }
        }

        return total;
    }
}