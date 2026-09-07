public class Solution {
    public int MissingMultiple(int[] nums, int k) {
        HashSet<int> numSet = new HashSet<int>(nums);

        for (int i = 1; i <= nums.Length + 1; i++) {
            int candidate = k * i;
            if (!numSet.Contains(candidate)) {
                return candidate;
            }
        }
        return -1;
    }
}