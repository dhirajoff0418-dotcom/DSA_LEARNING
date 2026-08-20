public class Solution {
    public bool IsEven(int n){
        string s = n.ToString();
        if(s.Length % 2 == 0){
            return true;
        }
        return false;
    }
    
    public int FindNumbers(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            bool isEven = IsEven(nums[i]);
            if(isEven){
                count++;
            }
        }
        return count;
    }
}