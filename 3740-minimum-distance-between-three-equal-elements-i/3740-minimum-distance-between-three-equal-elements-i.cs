public class Solution {
    public int MinimumDistance(int[] nums) {
         int result = int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                for(int k=j+1;k<nums.Length;k++){
                    if(nums[i]==nums[j] && nums[j]==nums[k]){
                        result=Math.Min(result,2*(k-i));
                    }
                }
            }
        }
        return result == int.MaxValue ? -1 : result;
    }
}