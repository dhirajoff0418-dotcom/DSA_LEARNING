public class Solution {
   public int Reverse(int n){
    int result = 0;
    while(n > 0){
        int digit = n % 10; 
        result = result * 10 + digit;
        n = n / 10;
    }
    return result;
    }
    public int MirrorDistance(int n) {
        int mirror=Reverse(n);
       return Math.Abs(n-mirror);
    }
}