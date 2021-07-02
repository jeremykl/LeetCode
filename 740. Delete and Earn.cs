public class Solution
{
	public int DeleteAndEarn(int[] nums)
	{
		int[] counts = new int[10001];
		foreach (int i in nums)
		{
			counts[i]++;
		}
		int include = 0, exclude = 0, prev = -1;

		for (int i = 0; i < 10000; i++)
		{
			int m = Math.Max(include, exclude);
			include = i * counts[i] + exclude;
			exclude = m;
		}
		return Math.Max(include, exclude);
	}
}