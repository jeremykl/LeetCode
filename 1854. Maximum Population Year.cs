public class Solution
{
	public int MaximumPopulation(int[][] logs)
	{
		int[] years = new int[101];
		foreach (var log in logs)
		{
			years[log[0] - 1950]++;
			years[log[1] - 1950]--;
		}
		int max = 1950;
		int maxCount = 0;
		int count = 0;
		for (int i = 0; i < years.Length; i++)
		{
			if (years[i] > 0 && count + years[i] > maxCount)
			{
				max = 1950 + i;
				maxCount = count + years[i];
			}
			count += years[i];
		}
		return max;
	}
}