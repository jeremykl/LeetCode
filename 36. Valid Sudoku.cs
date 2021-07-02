public class Solution
{
	public bool IsValidSudoku(char[][] board)
	{
		if (!ValidRowsCols(board)) return false;
		if (!Valid3s(board)) return false;
		return true;
	}

	private bool ValidRowsCols(char[][] board)
	{
		for (int i = 0; i < 9; i++)
		{
			HashSet<char> hsr = new HashSet<char>();
			HashSet<char> hsc = new HashSet<char>();
			for (int j = 0; j < 9; j++)
			{
				if (board[i][j] != '.' && hsr.Contains(board[i][j])) return false;
				hsr.Add(board[i][j]);

				if (board[j][i] != '.' && hsc.Contains(board[j][i])) return false;
				hsc.Add(board[j][i]);
			}
		}
		return true;
	}

	private bool Valid3s(char[][] board)
	{
		for (int i = 0; i < 9; i += 3)
		{
			for (int j = 0; j < 9; j += 3)
			{
				HashSet<char> hs = new HashSet<char>();
				// board[i][j] is top left cell of a 3x3
				for (int x = i; x < i + 3; x++)
				{
					for (int y = j; y < j + 3; y++)
					{
						if (board[x][y] != '.' && hs.Contains(board[x][y])) return false;
						hs.Add(board[x][y]);
					}
				}
			}
		}
		return true;
	}
}