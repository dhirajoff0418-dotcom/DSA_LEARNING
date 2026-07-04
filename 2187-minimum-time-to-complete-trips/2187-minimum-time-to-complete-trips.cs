public class Solution
{
    public bool Possible(int[] time, long givenTime, int totalTrips)
    {
        long actualTrips = 0;

        for (int i = 0; i < time.Length; i++)
        {
            actualTrips += givenTime / time[i];

            if (actualTrips >= totalTrips)
                return true;
        }

        return false;
    }

    public long MinimumTime(int[] time, int totalTrips)
    {
        long l = 1;
        long r = (long)time.Min() * totalTrips;

        while (l < r)
        {
            long mid = l + (r - l) / 2;

            if (Possible(time, mid, totalTrips))
                r = mid;
            else
                l = mid + 1;
        }

        return l;
    }
}