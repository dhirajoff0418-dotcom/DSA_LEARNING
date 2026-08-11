public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1)
        {
            if (seen.Contains(n))
                return false;

            seen.Add(n);

            int sqrSum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sqrSum += digit * digit;
                n /= 10;
            }

            n = sqrSum;
        }

        return true;
    }
}