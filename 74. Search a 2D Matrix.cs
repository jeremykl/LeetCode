public class Solution
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		int n = matrix[0].Length;
		int i = 0;
		// Find the right row
		while (i < matrix.Length - 1 && target > matrix[i][n - 1])
		{
			i++;
		}
		// Look for target
		for (int j = 0; j < n; j++)
		{
			if (matrix[i][j] == target) return true;
		}
		return false;
	}
}