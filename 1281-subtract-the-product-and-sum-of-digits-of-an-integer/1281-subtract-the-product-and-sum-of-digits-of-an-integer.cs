public class Solution {
    public int SubtractProductAndSum(int n) {
        int prod=1;
        int sum=0;
        while(n >0){
            int num=n%10;
            sum +=num;
            prod *=num;
            n=n/10;
        }
        return (prod-sum);
    }
}