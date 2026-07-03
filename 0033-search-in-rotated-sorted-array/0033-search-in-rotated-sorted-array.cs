public class Solution {

    public int Pivot(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;

        while (i < j) {
            int mid = i + (j - i) / 2;

            if (nums[mid] < nums[j])
                j = mid;
            else
                i = mid + 1;
        }

        return i;
    }

    public int BinarySearch(int l, int r, int[] nums, int target) {
        while (l <= r) {
            int mid = l + (r - l) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] < target)
                l = mid + 1;
            else
                r = mid - 1;
        }

        return -1;
    }

    public int Search(int[] nums, int target) {

        int n = nums.Length;
        int pivot = Pivot(nums);

        if (target >= nums[pivot] && target <= nums[n - 1])
            return BinarySearch(pivot, n - 1, nums, target);

        return BinarySearch(0, pivot - 1, nums, target);
    }
}