// public class Solution {
//     public bool IsEven(int n){
//         string s = n.ToString();
//         if(s.Length % 2 == 0){
//             return true;
//         }
//         return false;
//     }
    
//     public int FindNumbers(int[] nums) {
//         int count = 0;
//         for(int i = 0; i < nums.Length; i++){
//             bool isEven = IsEven(nums[i]);
//             if(isEven){
//                 count++;
//             }
//         }
//         return count;
//     }
// }


public class Solution {
    public bool IsEven(int n){
        int digitCount = 0;
        while(n > 0){
            n = n / 10;
            digitCount++;
        }
        return digitCount % 2 == 0;
    }
    
    public int FindNumbers(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(IsEven(nums[i])){
                count++;
            }
        }
        return count;
    }
}