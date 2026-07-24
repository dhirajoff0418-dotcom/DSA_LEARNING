public class Solution
{
    public int[] AvoidFlood(int[] rains)
    {
        int n = rains.Length;
        int[] ans = new int[n];

        // lake -> last rainy day
        Dictionary<int, int> lastRain = new Dictionary<int, int>();

        // Stores indices of dry days
        SortedSet<int> dryDays = new SortedSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (rains[i] == 0)
            {
                dryDays.Add(i);
                ans[i] = 1;
            }
            else
            {
                int lake = rains[i];
                ans[i] = -1;

                if (lastRain.ContainsKey(lake))
                {
                
                    int prev = lastRain[lake];
                    int dryDay = -1;

                    foreach (int day in dryDays.GetViewBetween(prev + 1, n))
                    {
                        dryDay = day;
                        break;
                    }

                    if (dryDay == -1)
                        return new int[0];

                    ans[dryDay] = lake;
                    dryDays.Remove(dryDay);
                }

                lastRain[lake] = i;
            }
        }

        return ans;
    }
}