public class Solution {
    // public IList<int> FindDisappearedNumbers(int[] nums)
    // {
    //     Array.Sort(nums);

    //     List<int> ans = new List<int>();
    //     int expected = 1;

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         if (nums[i] == expected)
    //         {
    //             expected++;
    //         }
    //         else if (nums[i] < expected)
    //         {
    //             continue;
    //         }
    //         else
    //         {
    //             while (expected < nums[i])
    //             {
    //                 ans.Add(expected);
    //                 expected++;
    //             }

    //             expected++;
    //         }
    //     }

    //     while (expected <= nums.Length)
    //     {
    //         ans.Add(expected);
    //         expected++;
    //     }

    //     return ans;
    // }
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> ans = new List<int>();
        for(int i=0;i<nums.Length;i++){
           int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }
        for(int i =0;i<nums.Length;i++){
            if(nums[i]>0){
                ans.Add(i+1);
            }
        }
        return ans;
    }
}