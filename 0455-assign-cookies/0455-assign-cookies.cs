public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int i = 0; // child
        int j = 0; // cookie
        int happy = 0;

        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                happy++;
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }

        return happy;
    }
}