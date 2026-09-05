public class Solution {
    public int FindMaxFrom(int start, int end, int[] nums){
    int Max = int.MinValue;
    for(int i = start; i <= end; i++){
        if(nums[i] > Max){
            Max = nums[i];
        }
    }
    return Max;
    }

    public int FindMinFrom(int start, int end, int[] nums){
        int Min = int.MaxValue;
        for(int i = start; i <= end; i++){
            if(nums[i] < Min){
                Min = nums[i];
            }
        }
        return Min;
    }
    public int FirstStableIndex(int[] nums, int k) {
        int n=nums.Length;
        for(int i=0;i<nums.Length;i++){
            int max=FindMaxFrom(0,i,nums);
            int min=FindMinFrom(i,n-1,nums);
            int CurrScore=max-min;
            if(CurrScore <=k){
                return i;
            }
        }
        return -1;
    }
}