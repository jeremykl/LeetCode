public class Solution
{
	public string TruncateSentence(string s, int k)
	{
		var sb = new StringBuilder();

		foreach (var l in s)
		{
			if (l == ' ' && --k == 0)
			{
				break;
			}

			sb.Append(l);
		}
		return sb.ToString();
	}
}