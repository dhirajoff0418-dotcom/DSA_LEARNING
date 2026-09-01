public class Solution 
{
    public int ThirdMax(int[] nums) 
    {
        long? first = null, second = null, third = null;

        foreach (int n in nums)
        {
            if (n == first || n == second || n == third)
                continue;

            if (first == null || n > first)
            {
                third = second;
                second = first;
                first = n;
            }
            else if (second == null || n > second)
            {
                third = second;
                second = n;
            }
            else if (third == null || n > third)
            {
                third = n;
            }
        }

        return (int)(third ?? first);
    }
}