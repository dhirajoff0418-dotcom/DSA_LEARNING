public class Solution
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        int count = 0;
        int left = 0;
        int sum = 0;

        for (int right = 0; right < arr.Length; right++)
        {
            // Add right element
            sum += arr[right];

            // Window size == k
            if (right - left + 1 == k)
            {
                double average = (double)sum / k;

                if (average >= threshold)
                {
                    count++;
                }

                // Remove left element
                sum -= arr[left];
                left++;
            }
        }

        return count;
    }
}