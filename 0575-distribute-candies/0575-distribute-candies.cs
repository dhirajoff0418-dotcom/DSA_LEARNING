public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        HashSet<int> types = new HashSet<int>();

        foreach (int candy in candyType)
        {
            types.Add(candy);
        }

        int canEat = candyType.Length / 2;

        return Math.Min(types.Count, canEat);
    }
}