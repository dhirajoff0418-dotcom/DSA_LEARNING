public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> row = new List<int>();

        long value = 1;

        for (int i = 0; i <= rowIndex; i++)
        {
            row.Add((int)value);

            value = value * (rowIndex - i) / (i + 1);
        }

        return row;
    }
}