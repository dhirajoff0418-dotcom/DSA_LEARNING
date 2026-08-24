public class Solution {
    private void Decide(int[] nums, int index, List<int> current, IList<IList<int>> result) {
        if(index==nums.Length){
            result.Add(new List<int>(current));
            return;
        }

    current.Add(nums[index]);
    Decide(nums, index + 1, current, result);
    current.RemoveAt(current.Count - 1);
    Decide(nums, index + 1, current, result);  
    }
    
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Decide(nums, 0, new List<int>(), result);
        return result;
    }
}