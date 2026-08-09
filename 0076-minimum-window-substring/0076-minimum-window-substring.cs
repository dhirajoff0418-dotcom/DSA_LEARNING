public class Solution
{
    public string MinWindow(string s, string t)
    {
        int n = s.Length;

        if (t.Length > n)
            return "";

        Dictionary<char, int> mp = new Dictionary<char, int>();

        // Frequency of characters required from t
        foreach (char ch in t)
        {
            if (mp.ContainsKey(ch))
                mp[ch]++;
            else
                mp[ch] = 1;
        }

        int reqC = t.Length;

        int i = 0;
        int j = 0;

        int windowSize = int.MaxValue;
        int startI = 0;

        while (j < n)
        {
            char ch = s[j];

            if (mp.ContainsKey(ch))
            {
                if (mp[ch] > 0)
                    reqC--;

                mp[ch]--;
            }

            // Current window contains all required characters
            while (reqC == 0)
            {
                int currWindowSize = j - i + 1;

                if (currWindowSize < windowSize)
                {
                    windowSize = currWindowSize;
                    startI = i;
                }

                char leftChar = s[i];

                if (mp.ContainsKey(leftChar))
                {
                    mp[leftChar]++;

                    if (mp[leftChar] > 0)
                        reqC++;
                }

                i++;
            }

            j++;
        }

        return windowSize == int.MaxValue
            ? ""
            : s.Substring(startI, windowSize);
    }
}