public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }

        return string.Join(" ", words);
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();

        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            char temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        return new string(arr);
    }
}