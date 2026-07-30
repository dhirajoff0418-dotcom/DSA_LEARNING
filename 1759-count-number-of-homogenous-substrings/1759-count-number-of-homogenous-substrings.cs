public class Solution
{
    public int CountHomogenous(string s)
    {
        long result = 0;
        long length = 0;
        int mod = 1000000007;

        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && s[i] == s[i - 1])
            {
                length++;
            }
            else
            {
                length = 1;
            }

            result = (result + length) % mod;
        }

        return (int)result;
    }
}