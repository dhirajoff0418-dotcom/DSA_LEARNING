public class Solution
{
    public int NumberOfSpecialChars(string word)
    {
        int answer = 0;

        for (char c = 'a'; c <= 'z'; c++)
        {
            int lastLower = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == c)
                {
                    lastLower = i;
                }
            }

            int firstUpper = -1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == char.ToUpper(c))
                {
                    firstUpper = i;
                    break;
                }
            }

            if (lastLower != -1 &&
                firstUpper != -1 &&
                lastLower < firstUpper)
            {
                answer++;
            }
        }

        return answer;
    }
}