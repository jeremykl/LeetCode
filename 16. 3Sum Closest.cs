public class Solution
{
	public int ThreeSumClosest(int[] nums, int target)
	{
		// 3Sum, but keep track of how close we have gotten to the target
		Array.Sort(nums);
		int diff = int.MaxValue;
		for (int i = 0; i < nums.Length && 0 != diff; i++)
		{
			int lo = i + 1, hi = nums.Length - 1;
			while (lo < hi)
			{
				int sum = nums[i] + nums[lo] + nums[hi];
				if (Math.Abs(target - sum) < Math.Abs(diff)) diff = target - sum;
				if (sum < target)
				{
					lo++;
				}
				else
				{
					hi--;
				}
			}
		}
		return target - diff;
	}
}