public class Solution
{
	public int MaxSubArray(int[] nums)
	{
		int sum = nums[0];
		int max = nums[0];

		for (int i = 1; i < nums.Length; i++)
		{
			sum += nums[i];

			if (nums[i] > sum)
			{
				sum = nums[i];
			}

			if (sum > max)
			{
				max = sum;
			}
		}

		return max;
	}
}