public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int pairs = 0;
        Dictionary<int, int> mp = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (mp.ContainsKey(num))
            {
                pairs += mp[num];
                mp[num]++;
            }
            else
            {
                mp[num] = 1;
            }
        }

        return pairs;
    }
}