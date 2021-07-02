public class Solution
{
	public int MaxSumAfterPartitioning(int[] arr, int k)
	{
		int[] dp = new int[arr.Length + 1];
		for (int i = 1; i <= arr.Length; i++)
		{
			int currentMax = 0;
			int best = 0;
			for (int K = 1; K <= k && i - K >= 0; K++)
			{
				currentMax = Math.Max(currentMax, arr[i - K]);
				best = Math.Max(best, dp[i - K] + currentMax * K);
			}
			dp[i] = best;
		}
		return dp[arr.Length];
	}
}