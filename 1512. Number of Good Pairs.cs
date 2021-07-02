public class Solution
{
	public int NumIdenticalPairs(int[] nums)
	{
		int[] countPerNumber = new int[101];
		int maxPossiblePairs = 0;
		// Get the number of times a number occurs 
		for (int i = 0; i < nums.Length; i++)
		{
			int val = nums[i];
			if (val > maxPossiblePairs)
			{
				maxPossiblePairs = val;
			}
			countPerNumber[val]++;
		}

		// Loop through all numbers up through max recorded number
		// Record the number of combinations
		int results = 0;
		for (int i = 0; i <= maxPossiblePairs; i++)
		{
			if (countPerNumber[i] > 1)
			{
				results += countPerNumber[i] * (countPerNumber[i] - 1);
			}
		}
		return results / 2;
	}
}