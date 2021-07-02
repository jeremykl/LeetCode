public class Solution
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		if (matrix == null || matrix.Length < 1 || matrix[0].Length < 1)
		{
			return false;
		}
		int col = matrix[0].Length - 1;
		int row = 0;
		while (col >= 0 && row <= matrix.Length - 1)
		{
			if (target == matrix[row][col])
			{
				return true;
			}
			else if (target < matrix[row][col])
			{
				col--;
			}
			else if (target > matrix[row][col])
			{
				row++;
			}
		}
		return false;
	}
}