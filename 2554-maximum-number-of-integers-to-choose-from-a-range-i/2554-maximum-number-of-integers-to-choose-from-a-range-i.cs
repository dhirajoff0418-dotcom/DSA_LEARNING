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


    /* To reuce the traversing of teh array again and again we can use hashet and keep the array in hash set for better searching */
    // public int MaxCount(int[] banned, int n, int maxSum)
    // {
    //     HashSet<int> bannedSet = new HashSet<int>(banned);

    //     int count = 0;
    //     int sum = 0;

    //     for (int i = 1; i <= n; i++)
    //     {
    //         if (!bannedSet.Contains(i) && sum + i <= maxSum)
    //         {
    //             sum += i;
    //             count++;
    //         }
    //     }

    //     return count;
    // }
}