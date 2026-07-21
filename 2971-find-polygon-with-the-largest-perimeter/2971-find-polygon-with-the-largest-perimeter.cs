public class Solution {
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);

        long currSum = 0;
        long peri = -1;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < currSum) {
                peri = currSum + nums[i];
            }
            currSum += nums[i];
        }

        return peri;
    }
}