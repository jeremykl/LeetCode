public class Solution
{
	public int MaxProfit(int[] prices)
	{
		int i = 0;
		int peak = 0;
		int valley = 0;
		int sum = 0;
		while (i < prices.Length - 1)
		{
			while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
			{
				i++;
			}
			valley = prices[i];
			while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
			{
				i++;
			}
			peak = prices[i];
			sum += peak - valley;
		}
		return sum;
	}
}