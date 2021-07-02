public class Solution
{
	public IList<string> GenerateParenthesis(int n)
	{
		List<string> result = new List<string>();
		backtrack(result, new StringBuilder(), 0, 0, n);
		return result;
	}

	private void backtrack(List<string> result, StringBuilder curr, int open, int close, int max)
	{
		if (curr.Length == max * 2)
		{
			result.Add(curr.ToString());
			return;
		}

		if (open < max)
		{
			curr.Append("(");
			backtrack(result, curr, open + 1, close, max);
			curr.Remove(curr.Length - 1, 1);
		}

		if (close < open)
		{
			curr.Append(")");
			backtrack(result, curr, open, close + 1, max);
			curr.Remove(curr.Length - 1, 1);
		}
	}
}