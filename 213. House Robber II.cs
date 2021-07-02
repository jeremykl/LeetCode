public class Solution
{
	public int Rob(int[] nums)
	{
		if (nums.Length == 1) return nums[0];
		return Math.Max(row(nums, 0, nums.Length - 2), row(nums, 1, nums.Length - 1));
	}

	private int row(int[] nums, int lo, int hi)
	{
		int include = 0, exclude = 0;
		for (int j = lo; j <= hi; j++)
		{
			int i = include, e = exclude;
			include = e + nums[j];
			exclude = Math.Max(e, i);
		}
		return Math.Max(include, exclude);
	}
}