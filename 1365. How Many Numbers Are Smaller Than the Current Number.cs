public class Solution
{
	public int[] SmallerNumbersThanCurrent(int[] nums)
	{
		int[] numbersLessThanOrEqualTo = new int[101];
		int[] result = new int[nums.Length];

		for (int i = 0; i < nums.Length; i++)
		{
			numbersLessThanOrEqualTo[nums[i]]++;
		}

		for (int i = 1; i < numbersLessThanOrEqualTo.Length; i++)
		{
			numbersLessThanOrEqualTo[i] += numbersLessThanOrEqualTo[i - 1];
		}

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
			{
				result[i] = 0;
			}
			else
			{
				result[i] = numbersLessThanOrEqualTo[nums[i] - 1];
			}
		}
		return result;
	}
}