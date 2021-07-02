public class Solution
{
	public bool WordBreak(string s, IList<string> wordDict)
	{
		bool[] dp = new bool[s.Length + 1];
		dp[0] = true;
		for (int len = 1; len <= s.Length; len++)
		{
			for (int i = 0; i < len; i++)
			{
				if (dp[i] && wordDict.Contains(s.Substring(i, len - i)))
				{
					dp[len] = true;
					break;
				}
			}
		}
		return dp[s.Length];
	}
}