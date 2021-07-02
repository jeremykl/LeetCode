public class Solution
{
	public int GetMinDistance(int[] nums, int target, int start)
	{
		int minDistance = nums.Length;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == target && minDistance > Math.Abs(start - i))
			{
				minDistance = Math.Abs(start - i);
			}
		}
		return minDistance;
	}
}