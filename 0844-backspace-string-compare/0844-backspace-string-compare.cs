public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        string res1 = "";
        string res2 = "";

        char[] chars1 = s.ToCharArray();
        char[] chars2 = t.ToCharArray();

        // Process s
        for (int i = 0; i < chars1.Length; i++)
        {
            if (chars1[i] >= 'a' && chars1[i] <= 'z')
            {
                res1 += chars1[i];
            }
            else
            {
                if (res1.Length > 0)
                {
                    res1 = res1.Substring(0, res1.Length - 1);
                }
            }
        }

        // Process t
        for (int i = 0; i < chars2.Length; i++)
        {
            if (chars2[i] >= 'a' && chars2[i] <= 'z')
            {
                res2 += chars2[i];
            }
            else
            {
                if (res2.Length > 0)
                {
                    res2 = res2.Substring(0, res2.Length - 1);
                }
            }
        }

        return res1 == res2;
    }
}