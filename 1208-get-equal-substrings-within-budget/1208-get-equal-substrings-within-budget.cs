public class Solution
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        int left = 0;
        int cost = 0;
        int answer = 0;

        for (int right = 0; right < s.Length; right++)
        {
            cost += Math.Abs(s[right] - t[right]);

            while (cost > maxCost)
            {
                cost -= Math.Abs(s[left] - t[left]);
                left++;
            }

            answer = Math.Max(answer, right - left + 1);
        }

        return answer;
    }
}