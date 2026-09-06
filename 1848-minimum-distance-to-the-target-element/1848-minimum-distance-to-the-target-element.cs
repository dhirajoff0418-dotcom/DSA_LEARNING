public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int op=int.MaxValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                op=Math.Min(op,Math.Abs(i-start) );
            }
        }
        return op;
    }
}