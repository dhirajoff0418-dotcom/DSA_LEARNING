public class Solution
{
    public long CountSubstrings(string s, char c)
    {
        long count = 0;
        long subCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                count++;
                subCount += count;
            }
        }

        return subCount;
    }
}