public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);

List<int> result = new List<int>();

for (int i = 0; i < spells.Length; i++)
{
    int l = 0;
    int r = potions.Length - 1;

    while (l <= r)
    {
        int mid = l + (r - l) / 2;

        if ((long)spells[i] * potions[mid] >= success)
        {
            r = mid - 1;
        }
        else
        {
            l = mid + 1;
        }
    }

    result.Add(potions.Length - l);
}

return result.ToArray();
    }
}