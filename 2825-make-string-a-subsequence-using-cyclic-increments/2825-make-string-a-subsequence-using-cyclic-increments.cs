public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int n = str1.Length;
        int m = str2.Length;

        int i = 0;
        int j = 0;

        while (i < n && j < m)
        {
            if (str1[i] == str2[j] ||
                (str1[i] != 'z' && str1[i] + 1 == str2[j]) ||
                (str1[i] == 'z' && str2[j] == 'a'))
            {
                j++;
            }

            i++;
        }

        return j == m;
    }
}