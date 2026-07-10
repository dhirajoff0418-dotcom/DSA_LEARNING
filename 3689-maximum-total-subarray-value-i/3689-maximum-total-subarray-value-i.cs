public class Solution {
    public int FindMax(int[] nums)
    {
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        return max;
    }

    public int FindMin(int[] nums)
    {
        int min = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return min;
    }
    public long MaxTotalValue(int[] nums, int k) {
        // we will choose max of sub array and min of subaarray and multiply with the k beacuse the max is more and the min is less we get max value after difference

        int max=FindMax(nums);
        int min=FindMin(nums);
        return ((long)max - min) * k;
    }
}