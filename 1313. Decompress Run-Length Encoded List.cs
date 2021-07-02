public class Solution
{
	public int[] DecompressRLElist(int[] nums)
	{
		List<int> l = new List<int>();
		for (int i = 0; i < nums.Length; i += 2)
		{
			for (int j = 0; j < nums[i]; j++)
			{
				l.Add(nums[i + 1]);
			}
		}
		return l.ToArray();
	}
}