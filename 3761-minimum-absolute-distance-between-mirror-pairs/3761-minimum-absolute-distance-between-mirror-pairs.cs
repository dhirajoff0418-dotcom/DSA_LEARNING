public class Solution
{
    public int Reverse(int n)
    {
        int reverse = 0;

        while (n > 0)
        {
            int digit = n % 10;
            reverse = reverse * 10 + digit;
            n /= 10;
        }

        return reverse;
    }
    // public int MinMirrorPairDistance(int[] nums)
    // {
    //     // Brute force
    //     int minDifference = int.MaxValue;

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             int reverse = Reverse(nums[i]);

    //             if (reverse == nums[j])
    //             {
    //                 minDifference = Math.Min(minDifference, j - i);
    //             }
    //         }
    //     }

    //     return minDifference == int.MaxValue ? -1 : minDifference;
    // }
    public int MinMirrorPairDistance(int[] nums)
    {
        int minDifference = int.MaxValue;
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int j = 0; j < nums.Length; j++)
        {
            if (map.ContainsKey(nums[j]))
            {
                minDifference = Math.Min(
                    minDifference,
                    j - map[nums[j]]
                );
            }

            int reversed = Reverse(nums[j]);

            map[reversed] = j;
        }

        return minDifference == int.MaxValue ? -1 : minDifference;
    }
}