public class Solution
{
    public int FindGcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    public int MinOperations(int[] nums)
    {
        int n = nums.Length;
        int countOne = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 1)
                countOne++;
        }

        // Already have one(s)
        if (countOne > 0)
            return n - countOne;

        int minLength = int.MaxValue;

        // Find shortest subarray with gcd = 1
        for (int i = 0; i < n; i++)
        {
            int gcd = nums[i];

            for (int j = i; j < n; j++)
            {
                gcd = FindGcd(gcd, nums[j]);

                if (gcd == 1)
                {
                    minLength = Math.Min(minLength, j - i + 1);
                    break;
                }
            }
        }

        if (minLength == int.MaxValue)
            return -1;

        return (minLength - 1) + (n - 1);
    }
}