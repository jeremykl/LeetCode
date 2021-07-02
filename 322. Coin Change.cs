public class Solution
{
	public int CoinChange(int[] coins, int amount)
	{
		int[] dp = new int[amount + 1];

		for (int i = 1; i <= amount; i++)
		{
			dp[i] = int.MaxValue;
			for (int j = 0; j < coins.Length; j++)
			{
				if (i >= coins[j] && dp[i - coins[j]] != int.MaxValue)
				{
					dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
				}
			}
		}
		return dp[amount] == int.MaxValue ? -1 : dp[amount];
	}
}