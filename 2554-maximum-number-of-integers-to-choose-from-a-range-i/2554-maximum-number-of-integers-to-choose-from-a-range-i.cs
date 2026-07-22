public class Solution
{
    public bool FindNotBand(int num, int[] banned)
    {
        for (int i = 0; i < banned.Length; i++)
        {
            if (banned[i] == num)
                return true;
        }

        return false;
    }

    public int MaxCount(int[] banned, int n, int maxSum)
    {
        int count = 0;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            bool isBanned = FindNotBand(i, banned);

            if (!isBanned && sum + i <= maxSum)
            {
                count++;
                sum += i;
            }
        }

        return count;
    }
}