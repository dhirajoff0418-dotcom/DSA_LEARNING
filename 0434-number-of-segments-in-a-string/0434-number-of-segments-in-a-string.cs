public class Solution {
    public int CountSegments(string s) {
        int count = 0;

        for (int i = 0; i < s.Length; i++) {

            // Agar current character space nahi hai
            // aur ya to ye pehla character hai
            // ya iske pehle space hai,
            // to ek naya word start hua.
            if (s[i] != ' ' && (i == 0 || s[i - 1] == ' ')) {
                count++;
            }
        }

        return count;
    }
}