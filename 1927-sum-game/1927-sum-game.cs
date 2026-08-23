public class Solution
{
    public bool SumGame(string num)
    {
        int n = num.Length;
        int half = n / 2;

        int sum1 = 0, sum2 = 0;
        int cnt1 = 0, cnt2 = 0;

        for (int i = 0; i < half; i++)
        {
            if (num[i] == '?')
                cnt1++;
            else
                sum1 += num[i] - '0';
        }

        for (int i = half; i < n; i++)
        {
            if (num[i] == '?')
                cnt2++;
            else
                sum2 += num[i] - '0';
        }

        int totalQ = cnt1 + cnt2;

        if (totalQ % 2 == 1)
        {
            return true;
        }

        int diff = sum1 - sum2;
        int finalDiff = 2 * diff + 9 * (cnt1 - cnt2);

        return finalDiff != 0;
    }
}