public class NumArray
{
    private int[] arr;

    public NumArray(int[] nums)
    {
        arr = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;

        for (int i = left; i <= right; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}