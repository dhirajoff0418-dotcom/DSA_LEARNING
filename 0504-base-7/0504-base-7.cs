public class Solution {
    public string ConvertToBase7(int num) {
        if (num == 0) return "0";
        
        bool isNegative = num < 0;
        int n = Math.Abs(num);
        
        string str = "";
        while (n > 0) {
            int digit = n % 7;
            str = digit + str;
            n = n / 7;
        }
        
        if (isNegative) str = "-" + str;
        
        return str;
    }
}