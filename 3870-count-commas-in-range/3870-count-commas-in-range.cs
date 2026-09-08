public class Solution {
    public int CountCommas(int n) {
        int totalCommas = 0;
        for(int i = 1; i <= n; i++){
            int digitCount = i.ToString().Length;
            int commasForThisNumber = (digitCount - 1) / 3;
            totalCommas += commasForThisNumber;
        }
        return totalCommas;
    }
}