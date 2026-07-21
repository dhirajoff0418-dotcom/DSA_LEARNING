public class Solution {
    public int MaximumScore(int[] nums, int k) {
        int i=k;
        int j=k;
        int currMin=nums[k];
        int result=nums[k];
        int n=nums.Length;
        while(i >0 || j <n-1){
            int leftValue = (i > 0) ? nums[i - 1] : 0;
            int rightValue = (j < n - 1) ? nums[j + 1] : 0;
            if(leftValue >rightValue){
               i--;
               currMin=Math.Min(currMin,nums[i]);
            }else{
                j++;
               currMin=Math.Min(currMin,nums[j]);
            }
            result =Math.Max(result,currMin *(j-i+1));
        }
        return result;
    }
}