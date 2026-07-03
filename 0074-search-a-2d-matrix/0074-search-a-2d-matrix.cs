public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;

        int i = 0;
        int j = m - 1;

        while (i < n && j >= 0) {
            if (matrix[i][j] > target) {
                j--;
            }
            else if (matrix[i][j] < target) {
                i++;
            }
            else {
                return true;
            }
        }

        return false;
    }
}