public class Solution
{
	public int MissingNumber(int[] nums)
	{
		int sum = 0, idealSum = nums.Length * (nums.Length + 1) / 2;
		foreach (int num in nums)
		{
			sum += num;
		}
		return idealSum - sum;
	}
}