public class Solution
{
    public IList<int> FindMissingElements(int[] nums)
    {
        Array.Sort(nums);

        List<int> newArr = new List<int>();

        int start = nums[0];
        int end = nums[nums.Length - 1];

        for (int i = start; i <= end; i++)
        {
            if (!Array.Exists(nums, x => x == i))
            {
                newArr.Add(i);
            }
        }

        return newArr;
    }
}