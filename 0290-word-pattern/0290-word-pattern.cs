public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');

        if (pattern.Length != words.Length)
            return false;

        Dictionary<char, string> patternToWord = new Dictionary<char, string>();
        Dictionary<string, char> wordToPattern = new Dictionary<string, char>();

        for (int i = 0; i < words.Length; i++)
        {
            char patternChar = pattern[i];
            string word = words[i];

            if (patternToWord.ContainsKey(patternChar))
            {
                if (patternToWord[patternChar] != word)
                    return false;
            }
            else
            {
                patternToWord[patternChar] = word;
            }

            if (wordToPattern.ContainsKey(word))
            {
                if (wordToPattern[word] != patternChar)
                    return false;
            }
            else
            {
                wordToPattern[word] = patternChar;
            }
        }

        return true;
    }
}