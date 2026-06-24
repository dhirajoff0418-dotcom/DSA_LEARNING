public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            var row = new List<int>();

            for (int j = 0; j <= i; j++) {
                if (j == 0 || j == i) {
                    row.Add(1);
                } else {
                    var prevRow = result[i - 1];
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }
            }

            result.Add(row);
        }

        return result;
    }
}