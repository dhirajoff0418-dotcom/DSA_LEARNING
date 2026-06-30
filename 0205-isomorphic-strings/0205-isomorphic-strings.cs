public class Solution {
    public bool IsIsomorphic(string s, string t) {

        Dictionary<char, char> map = new Dictionary<char, char>();
        HashSet<char> used = new HashSet<char>();

        for (int i = 0; i < s.Length; i++) {

            char c1 = s[i];
            char c2 = t[i];

            if (map.ContainsKey(c1)) {

                // Agar mapping pehle se hai,
                // to check karo ki wahi character map ho raha hai.
                if (map[c1] != c2) {
                    return false;
                }

            } else {

                // Agar c2 kisi aur ke liye already use ho chuka hai
                if (used.Contains(c2)) {
                    return false;
                }

                // Nayi mapping
                map.Add(c1,c2);
                used.Add(c2);
            }
        }

        return true;
    }
}