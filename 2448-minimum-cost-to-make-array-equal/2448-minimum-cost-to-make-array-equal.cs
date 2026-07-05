public class Solution {
   private long Calculate(int val, int[] nums, int[] cost)
    {
        long res = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            res += (long)Math.Abs(val - nums[i]) * cost[i];
        }

        return res;
    }
   public long MinCost(int[] nums, int[] cost)
    {
    long answer = long.MaxValue;

    int l = nums.Min();
    int r = nums.Max();

    while (l <= r)
    {
        int mid = l + (r - l) / 2;

        long midCost = Calculate(mid, nums, cost);
        long nextCost = Calculate(mid + 1, nums, cost);

        answer = Math.Min(answer, Math.Min(midCost, nextCost));

        if (midCost <= nextCost)
            r = mid - 1;
        else
            l = mid + 1;
    }

    return answer;
    }
}