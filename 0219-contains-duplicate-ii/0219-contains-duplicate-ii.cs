public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> set = new HashSet<int>();

        int i = 0;

        for (int j = 0; j < nums.Length; j++)
        {
            if (set.Contains(nums[j]))
            {
                return true;
            }

            set.Add(nums[j]);

            if (j - i >= k)
            {
                set.Remove(nums[i]);
                i++;
            }
        }

        return false;
    }
}