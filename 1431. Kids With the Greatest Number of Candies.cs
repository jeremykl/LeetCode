public class Solution
{
	public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
	{
		int maxNormalCandies = 0;
		foreach (int candy in candies)
		{
			if (candy > maxNormalCandies)
			{
				maxNormalCandies = candy;
			}
		}
		maxNormalCandies -= extraCandies;

		bool[] result = new bool[candies.Length];
		for (int i = 0; i < candies.Length; i++)
		{
			result[i] = candies[i] >= maxNormalCandies;
		}
		return result;
	}
}