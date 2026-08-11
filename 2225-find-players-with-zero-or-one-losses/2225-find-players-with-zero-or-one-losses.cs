public class Solution
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        Dictionary<int, int> losses = new Dictionary<int, int>();

        foreach (var match in matches)
        {
            int winner = match[0];
            int loser = match[1];

            if (!losses.ContainsKey(winner))
                losses[winner] = 0;

            if (!losses.ContainsKey(loser))
                losses[loser] = 0;

            losses[loser]++;
        }

        List<int> notLost = new List<int>();
        List<int> lostOnce = new List<int>();

        foreach (var player in losses)
        {
            if (player.Value == 0)
                notLost.Add(player.Key);

            else if (player.Value == 1)
                lostOnce.Add(player.Key);
        }

        notLost.Sort();
        lostOnce.Sort();

        return new List<IList<int>>
        {
            notLost,
            lostOnce
        };
    }
}