public class Solution {
    public string BreakPalindrome(string palindrome) {

        int n = palindrome.Length;

        if (n == 1)
            return "";

        char[] arr = palindrome.ToCharArray();

        for (int i = 0; i < n / 2; i++) {
            if (arr[i] != 'a') {
                arr[i] = 'a';
                return new string(arr);
            }
        }

        arr[n - 1] = 'b';
        return new string(arr);
    }
}