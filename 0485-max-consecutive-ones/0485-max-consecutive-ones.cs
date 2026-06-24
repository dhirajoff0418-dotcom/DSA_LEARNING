public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count=0;
        int maxC=0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==1){
                count++;
            }else{
                maxC=Math.Max(count,maxC);
                count=0;
            }
        }
        return Math.Max(count,maxC);
    }
}