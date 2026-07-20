public class Solution
{
    public int MinOperations(int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        int operations = 0;

        foreach (int count in freq.Values)
        {
            if (count == 1)
                return -1;

            if (count % 3 == 0)
            {
                operations += count / 3;
            }
            else if (count % 3 == 1)
            {
                operations += (count - 4) / 3 + 2;
            }
            else // count % 3 == 2
            {
                operations += count / 3 + 1;
            }
        }

        return operations;
    }
}