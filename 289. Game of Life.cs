public class Solution
{
	public void GameOfLife(int[][] board)
	{
		(int, int)[] neighbors = new (int, int)[] { (-1, 0), (-1, -1), (0, -1), (1, -1), (1, 0), (1, 1), (0, 1), (-1, 1) };

		for (int i = 0; i < board.Length; i++)
		{
			for (int j = 0; j < board[i].Length; j++)
			{
				int liveNeighbors = 0;
				foreach (var neighbor in neighbors)
				{
					if (
						i + neighbor.Item1 >= 0 &&
						i + neighbor.Item1 < board.Length &&
						j + neighbor.Item2 >= 0 &&
						j + neighbor.Item2 < board[i + neighbor.Item1].Length
					)
					{
						if (board[i + neighbor.Item1][j + neighbor.Item2] == 1 ||
						   board[i + neighbor.Item1][j + neighbor.Item2] == 3) liveNeighbors++;
					}
				}
				// Rules
				bool live = board[i][j] == 1;
				if (live && liveNeighbors < 2) board[i][j] = 3;
				if (live && liveNeighbors > 3) board[i][j] = 3;
				if (!live && liveNeighbors == 3) board[i][j] = 2;
			}
		}
		for (int i = 0; i < board.Length; i++)
		{
			for (int j = 0; j < board[i].Length; j++)
			{
				if (board[i][j] == 3)
				{
					board[i][j] = 0;
				}
				else if (board[i][j] == 2)
				{
					board[i][j] = 1;
				}
			}
		}
	}
}