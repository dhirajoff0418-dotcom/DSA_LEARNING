public class Solution {
    public int LongestMountain(int[] arr)
    {
        int n = arr.Length;
        int longest = 0;
        int i = 1;

        while (i < n - 1)
        {
            // Peak check: previous < current > next
            bool isPeak = arr[i - 1] < arr[i] && arr[i] > arr[i + 1];

            if (!isPeak)
            {
                i++;
                continue;
            }

            // Go left
            int left = i;
            while (left > 0 && arr[left - 1] < arr[left])
            {
                left--;
            }

            // Go right
            int right = i;
            while (right < n - 1 && arr[right] > arr[right + 1])
            {
                right++;
            }

            // Current mountain length
            longest = Math.Max(longest, right - left + 1);

            // Start looking after this mountain
            i = right;
        }

        return longest;
    }
}