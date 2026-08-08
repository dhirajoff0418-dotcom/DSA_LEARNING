public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int i = 0;
        int sum = 0;

        for (int j = 0; j < nums.Length; j++)
        {
            sum += nums[j];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, j - i + 1);

                sum -= nums[i];
                i++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}