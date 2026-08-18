public class Solution {
    // public IList<string> CommonChars(string[] words)
    // {
    //     List<string> result = new List<string>();

    //     int[] minFreq = new int[26];

    //     foreach (char c in words[0])
    //     {
    //         minFreq[c - 'a']++;
    //     }

    //     for (int i = 1; i < words.Length; i++)
    //     {
    //         int[] currentFreq = new int[26];

    //         foreach (char c in words[i])
    //         {
    //             currentFreq[c - 'a']++;
    //         }

    //         for (int j = 0; j < 26; j++)
    //         {
    //             minFreq[j] = Math.Min(minFreq[j], currentFreq[j]);
    //         }
    //     }

    //     for (int i = 0; i < 26; i++)
    //     {
    //         while (minFreq[i] > 0)
    //         {
    //             result.Add(((char)('a' + i)).ToString());
    //             minFreq[i]--;
    //         }
    //     }

    //     return result;
    // }

    public IList<string> CommonChars(string[] words)
    {
        List<string> result = new List<string>();

        string baseWord = words[0];

        for (int i = 0; i < baseWord.Length; i++)
        {
            char c = baseWord[i];
            bool common = true;

            for (int j = 1; j < words.Length; j++)
            {
                int index = words[j].IndexOf(c);

                if (index == -1)
                {
                    common = false;
                    break;
                }

                words[j] = words[j].Remove(index, 1);
            }

            if (common)
            {
                result.Add(c.ToString());
            }
        }

        return result;
    }
}