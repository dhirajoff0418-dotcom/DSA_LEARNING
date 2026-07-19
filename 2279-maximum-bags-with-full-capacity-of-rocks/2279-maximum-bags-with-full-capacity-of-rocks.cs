public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {

        int n = capacity.Length;
        int[] req = new int[n];

        for (int i = 0; i < n; i++) {
            req[i] = capacity[i] - rocks[i];
        }

        Array.Sort(req);

        int count = 0;

        for (int i = 0; i < n; i++) {

            if (req[i] <= additionalRocks) {
                additionalRocks -= req[i];
                count++;
            } else {
                break;
            }
        }

        return count;
    }
}