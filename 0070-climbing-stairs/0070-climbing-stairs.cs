public class Solution
{
    Dictionary<int, int> memo = new();

    public int ClimbStairs(int n)
    {
        if (n <= 1)
            return 1;

        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        return memo[n];
    }
}