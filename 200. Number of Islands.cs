public class Solution
{
	private int islands = 0;
	public int NumIslands(char[][] grid)
	{
		for (int i = 0; i < grid.Length; i++)
		{
			for (int j = 0; j < grid[i].Length; j++)
			{
				islands += helper(grid, (i, j));
			}
		}
		return islands;
	}

	private int helper(char[][] grid, (int, int) coords)
	{
		if (grid[coords.Item1][coords.Item2] == '0') return 0;
		grid[coords.Item1][coords.Item2] = '0';

		// left
		if (coords.Item2 > 0) helper(grid, (coords.Item1, coords.Item2 - 1));
		// right
		if (coords.Item2 < grid[coords.Item1].Length - 1) helper(grid, (coords.Item1, coords.Item2 + 1));
		// up
		if (coords.Item1 > 0) helper(grid, (coords.Item1 - 1, coords.Item2));
		// down
		if (coords.Item1 < grid.Length - 1) helper(grid, (coords.Item1 + 1, coords.Item2));

		return 1;
	}
}