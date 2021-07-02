public class Solution
{
	public int MaxAscendingSum(int[] nums)
	{
		int maxSum = 0;
		int currentSum = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (i == 0 || nums[i] > nums[i - 1])
			{
				currentSum += nums[i];
			}
			else
			{
				currentSum = nums[i];
			}

			if (currentSum > maxSum)
			{
				maxSum = currentSum;
			}
		}
		return maxSum;
	}
}