public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int n = nums.Length;
        int closestSum = nums[0] + nums[1] + nums[2];

        for(int k = 0; k < n - 2; k++){
            int i = k + 1;
            int j = n - 1;

            while(i < j){ 
                int sum = nums[k] + nums[i] + nums[j];

                if(Math.Abs(target - sum) < Math.Abs(target - closestSum)){
                    closestSum = sum;
                }

                if(sum < target){
                    i++;
                } else if(sum > target){
                    j--; 
                } else {
                    return sum;  
                }
            }
        }
        return closestSum;
    }
}