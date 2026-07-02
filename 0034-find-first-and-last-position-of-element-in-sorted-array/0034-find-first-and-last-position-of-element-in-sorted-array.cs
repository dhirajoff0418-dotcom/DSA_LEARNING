public class Solution {
    public int FindRightMost(int[] nums, int target, int n)
    {
        int l = 0;
        int r = n - 1;
        int rightMost = -1;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;

            if (nums[mid] == target)
            {
                rightMost = mid;
                l = mid + 1;
            }
            else if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return rightMost;
    }
   public int FindLeftMost(int[] nums, int target, int n)
    {
        int l = 0;
        int r = n - 1;
        int leftMost = -1;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;

            if (nums[mid] == target)
            {
                leftMost = mid;
                r = mid - 1;
            }
            else if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return leftMost;
    }
    public int[] SearchRange(int[] nums, int target) {
        int n=nums.Length;
        int leftMost=FindLeftMost(nums,target,n);
        int rightMost=FindRightMost(nums,target,n);

        return new int[] { leftMost, rightMost };
    }
}