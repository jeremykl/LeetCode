public class Solution
{
	public IList<IList<int>> ThreeSum(int[] nums)
	{
		// pre sort so that we know the right most pointer must decrease if the sum is > 0 and middle must increase if sum < 0
		Array.Sort(nums);
		List<IList<int>> l = new List<IList<int>>();
		for (int i = 0; i < nums.Length - 2; i++)
		{
			if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
			{
				int lo = i + 1, hi = nums.Length - 1, sum = 0 - nums[i];

				while (lo < hi)
				{
					if (nums[lo] + nums[hi] == sum)
					{
						l.Add(new List<int>(new int[] { nums[i], nums[lo], nums[hi] }));
						// avoid duplicate solutions
						while (lo < hi && nums[lo + 1] == nums[lo]) lo++;
						while (lo < hi && nums[hi - 1] == nums[hi]) hi--;
						lo++;
						hi--;
					}
					else if (nums[lo] + nums[hi] < sum)
					{
						lo++;
					}
					else
					{
						hi--;
					}
				}
			}
		}
		return l;
	}
}