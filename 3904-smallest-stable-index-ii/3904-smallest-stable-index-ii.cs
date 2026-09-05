public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
    int n = nums.Length;
    int[] prefixMax = new int[n];
    int[] suffixMin = new int[n];

    prefixMax[0] = nums[0];
    for(int i = 1; i < n; i++) 
        prefixMax[i] = Math.Max(prefixMax[i-1], nums[i]);

    suffixMin[n-1] = nums[n-1];
    for(int i = n-2; i >= 0; i--)
        suffixMin[i] = Math.Min(suffixMin[i+1], nums[i]);

    for(int i = 0; i < n; i++){ 
        if(prefixMax[i] - suffixMin[i] <= k)
            return i;
    }
    return -1;
}
}