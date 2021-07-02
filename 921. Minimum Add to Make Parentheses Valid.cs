public class Solution
{
	public int MinAddToMakeValid(string S)
	{
		int open = 0;
		int closed = 0;

		foreach (char c in S)
		{
			if (c == '(')
			{
				open++;
			}
			else
			{
				if (open > 0)
				{
					open--;
				}
				else
				{
					closed++;
				}
			}
		}
		return open + closed;
	}
}