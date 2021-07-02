public class Solution
{
	public int MaximumWealth(int[][] accounts)
	{
		int maxWealth = 0;
		foreach (int[] customer in accounts)
		{
			int wealth = 0;
			foreach (int val in customer)
			{
				wealth += val;
			}
			if (wealth > maxWealth)
			{
				maxWealth = wealth;
			}
		}
		return maxWealth;
	}
}