public class Solution
{
	public int ArrayPairSum(int[] nums)
	{
		Array.Sort(nums);
		int num = 0;
		for (int i = 0; i < nums.Length; i += 2)
		{
			num += nums[i];
		}
		return num;
	}
}