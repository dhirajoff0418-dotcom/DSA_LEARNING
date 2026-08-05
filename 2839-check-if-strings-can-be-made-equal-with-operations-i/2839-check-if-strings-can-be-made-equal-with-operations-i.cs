public class Solution
{
    public bool CanBeEqual(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int[] even = new int[26];
        int[] odd = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[s1[i] - 'a']++;
                even[s2[i] - 'a']--;
            }
            else
            {
                odd[s1[i] - 'a']++;
                odd[s2[i] - 'a']--;
            }
        }

        return even.All(x => x == 0) &&
               odd.All(x => x == 0);
    }
}