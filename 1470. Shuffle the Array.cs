public class Solution
{
	public int[] Shuffle(int[] nums, int n)
	{
		int[] shuffled = new int[n * 2];
		for (int i = 0; i < n; i++)
		{
			shuffled[i * 2] = nums[i];
			shuffled[i * 2 + 1] = nums[n + i];
		}
		return shuffled;
	}
}