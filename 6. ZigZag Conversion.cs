public class Solution
{
	public string Convert(string s, int numRows)
	{

		if (numRows == 1) return s;
		List<StringBuilder> rows = new List<StringBuilder>();
		for (int i = 0; i < numRows; i++)
		{
			rows.Add(new StringBuilder());
		}

		int currRow = 0;
		// start false for initial toggle to make true
		bool goingDown = false;

		foreach (char c in s)
		{
			rows[currRow].Append(c);
			if (currRow == 0 || currRow == numRows - 1) goingDown = !goingDown;
			currRow += goingDown ? 1 : -1;
		}

		StringBuilder result = new StringBuilder();
		foreach (StringBuilder sb in rows)
		{
			result.Append(sb);
		}
		return result.ToString();
	}
}