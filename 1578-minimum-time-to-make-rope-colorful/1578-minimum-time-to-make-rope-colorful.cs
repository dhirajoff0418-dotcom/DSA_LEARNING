public class Solution {
    public int MinCost(string colors, int[] neededTime) {

        int n = colors.Length;
        int time = 0;
        int prevMax = 0;

        for (int i = 0; i < n; i++) {

            if (i > 0 && colors[i] != colors[i - 1]) {
                prevMax = 0;
            }

            int curr = neededTime[i];
            time += Math.Min(prevMax, curr);
            prevMax = Math.Max(prevMax, curr);
        }

        return time;
    }
}