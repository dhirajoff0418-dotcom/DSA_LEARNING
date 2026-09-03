public class Solution {
    public bool UniformArray(int[] nums1) {
        int minOdd = int.MaxValue;
        int minEven = int.MaxValue;
        int oddCount = 0;
        int evenCount = 0;
        
        foreach (int x in nums1) {
            if (x % 2 == 0) {
                evenCount++;
                if (x < minEven) {
                    minEven = x;
                }
            } else {
                oddCount++;
                if (x < minOdd) {
                    minOdd = x;
                }
            }
        }
        
        if (oddCount == 0 || evenCount == 0) {
            return true;
        }
        
        return minOdd < minEven;
    }
}