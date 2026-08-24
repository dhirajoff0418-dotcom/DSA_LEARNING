public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        bool[] used = new bool[nums.Length];
        
        Backtrack(nums, current, used, result);
        return result;
    }
    
    private void Backtrack(int[] nums, List<int> current, bool[] used, IList<IList<int>> result) {
        if (current.Count == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) continue;
            
            current.Add(nums[i]);
            used[i] = true;
            
            Backtrack(nums, current, used, result);
            
            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
    }
}