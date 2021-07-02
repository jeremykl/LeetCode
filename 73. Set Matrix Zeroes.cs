public class Solution
{
	public void SetZeroes(int[][] matrix)
	{
		// Keep track of rows and columns that need to be zeroed out
		HashSet<int> rows = new HashSet<int>();
		HashSet<int> columns = new HashSet<int>();
		for (int i = 0; i < matrix.Length; i++)
		{
			for (int j = 0; j < matrix[i].Length; j++)
			{
				if (matrix[i][j] == 0)
				{
					rows.Add(i);
					columns.Add(j);
				}
			}
		}

		for (int i = 0; i < matrix.Length; i++)
		{
			for (int j = 0; j < matrix[i].Length; j++)
			{
				if (rows.Contains(i) || columns.Contains(j))
				{
					matrix[i][j] = 0;
				}
			}
		}
	}
}