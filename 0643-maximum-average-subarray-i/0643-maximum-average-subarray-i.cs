public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int i = 0;
        int prevSum = 0;
        double maxAverage = double.MinValue;

        for (int j = 0; j < nums.Length; j++)
        {
            // Add right element
            prevSum += nums[j];

            // Window size is k
            if (j - i + 1 == k)
            {
                // Calculate average of current window
                double currentAverage = (double)prevSum / k;

                // Update maximum
                maxAverage = Math.Max(maxAverage, currentAverage);

                // Remove left element
                prevSum -= nums[i];
                i++;
            }
        }

        return maxAverage;
    }
}