public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        char[] s = senate.ToCharArray();
        int rCount = 0, dCount = 0;

        foreach (char c in s)
        {
            if (c == 'R')
                rCount++;
            else
                dCount++;
        }

        while (rCount > 0 && dCount > 0)
        {
            for (int i = 0; i < s.Length && rCount > 0 && dCount > 0; i++)
            {
                if (s[i] == 'X') continue;

                if (s[i] == 'R')
                {
                    // Find next Dire senator
                    int j = (i + 1) % s.Length;
                    while (s[j] != 'D')
                    {
                        j = (j + 1) % s.Length;
                    }

                    s[j] = 'X';
                    dCount--;
                }
                else if (s[i] == 'D')
                {
                    // Find next Radiant senator
                    int j = (i + 1) % s.Length;
                    while (s[j] != 'R')
                    {
                        j = (j + 1) % s.Length;
                    }

                    s[j] = 'X';
                    rCount--;
                }
            }
        }

        return rCount > 0 ? "Radiant" : "Dire";
    }
}