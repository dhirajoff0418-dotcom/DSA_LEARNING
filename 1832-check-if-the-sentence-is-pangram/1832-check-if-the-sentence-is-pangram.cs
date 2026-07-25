public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        int[] arr = new int[26];

        for (int i = 0; i < sentence.Length; i++)
        {
            arr[sentence[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (arr[i] == 0)
                return false;
        }

        return true;
    }
}