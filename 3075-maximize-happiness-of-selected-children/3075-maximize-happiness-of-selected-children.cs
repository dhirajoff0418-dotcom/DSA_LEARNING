public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);

        long maxSum = 0;
        int childCount = 0;
        int i = happiness.Length - 1;  
        while (childCount < k && i >= 0)
        {
            int currentHappiness = happiness[i] - childCount;

            if (currentHappiness > 0)
            {
                maxSum += currentHappiness;
            }

            childCount++;
            i--;
        }

        return maxSum;
    }
}