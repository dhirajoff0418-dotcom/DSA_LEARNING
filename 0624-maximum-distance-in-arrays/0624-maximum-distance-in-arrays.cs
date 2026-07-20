public class Solution
{
    public int MaxDistance(IList<IList<int>> arrays)
    {
        int prevMin = arrays[0][0];
        int prevMax = arrays[0][arrays[0].Count - 1];

        int ans = 0;

        for (int i = 1; i < arrays.Count; i++)
        {
            int currMin = arrays[i][0];
            int currMax = arrays[i][arrays[i].Count - 1];

            ans = Math.Max(ans, Math.Max(
                Math.Abs(prevMax - currMin),
                Math.Abs(currMax - prevMin)
            ));

            prevMin = Math.Min(prevMin, currMin);
            prevMax = Math.Max(prevMax, currMax);
        }

        return ans;
    }
}