public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        uint num = (uint)n;
        while (num != 0) {
            count += (int)(num & 1);
            num >>= 1;
        }
        return count;
    }
}